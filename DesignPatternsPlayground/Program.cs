// See https://aka.ms/new-console-template for more information
using Models;
using Models.Enums;
using Services.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Contracts;
using Services;

var host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((context, services) =>
	{
		services.AddSingleton<IReportsFactory, ReportsFactory>();
		services.AddSingleton<IReportsGeneratorService, ReportsGeneratorService>();
	})
	.Build();

var reportGeneratorService = host.Services.GetRequiredService<IReportsGeneratorService>();


//Violation of the Dependency Inversion Principle

// "High level modules should not depend on low level modules. 
//  both should depend on abstractions"

InstantiatedReportGenerator instantiatedReportGenerator = new();

CustomReport customReport = instantiatedReportGenerator.GenerateCustomReport();
PreconfiguredReport preconfiguredReport = instantiatedReportGenerator.GeneratePreconfiguredReport();

Console.WriteLine(customReport.Name);
Console.WriteLine(preconfiguredReport.Name);

// ---------------------------------------------------------------------
//----------------------Factory approach--------------------------------

CustomReport customReportFromFactory = (CustomReport)reportGeneratorService
	.GenerateReportWithFactoryApproach((int)ReportTypeEnums.CustomReport);

PreconfiguredReport preconfiguredReportFromFactory = (PreconfiguredReport)reportGeneratorService
	.GenerateReportWithFactoryApproach((int)ReportTypeEnums.PreconfiguredReport);

Console.WriteLine();
Console.WriteLine(customReportFromFactory.Name);
Console.WriteLine(preconfiguredReportFromFactory.Name);

// ---------------------------------------------------------------------
//----------------------Builder approach--------------------------------

CustomReportBuilder customReportBuilder = new();
PreconfiguredReportBuilder preconfiguredReportBuilder = new();

ReportsBuilderDirector builderDirector = new ReportsBuilderDirector(1, 5895, 4009);

CustomReport customReportFromBuilder = builderDirector.GenerateCustomReport(customReportBuilder);
PreconfiguredReport preconfiguredReportfromBuilder = builderDirector.GeneratePreconfiguredReport(preconfiguredReportBuilder);


Console.WriteLine();
Console.WriteLine(customReportFromBuilder.Name);

foreach (var field in customReportFromBuilder.CustomFields)
{
	Console.WriteLine(field);
}

Console.WriteLine(preconfiguredReportfromBuilder.Name);

foreach (var field in preconfiguredReportfromBuilder.PreconfiguredFields)
{
	Console.WriteLine(field);
}

// ---------------------------------------------------------------------
//------------------------------PROTOTYPE-------------------------------
DevConfigPrototype myDevConfig = new DevConfigPrototype();
ProductionConfigPrototype myProdConfig = new ProductionConfigPrototype();

List<IPrototype> prototypes = new List<IPrototype>();

prototypes.Add(myDevConfig);
prototypes.Add(myProdConfig);

foreach (var prototype in prototypes)
{
	var clonedPrototype = prototype.Clone();

    Console.WriteLine();
    Console.WriteLine($"Cloned private info, conn str: {clonedPrototype.GetConnectionString()}");
}

// ---------------------------------------------------------------------
//----------------------Strategy approach--------------------------------

CustomReportStrategy customReportStrategy = new();
PreconfiguredReportStrategy preconfiguredReportStrategy = new();



CustomReport customReportFromStrategy = (CustomReport)customReportStrategy.GenerateReport(22, 8993, 9903);

PreconfiguredReport preconfiguredReportfromStrategy = (PreconfiguredReport)preconfiguredReportStrategy.GenerateReport(51, 2102, 1003);


Console.WriteLine();
Console.WriteLine(customReportFromStrategy.Name);

foreach (var field in customReportFromStrategy.CustomFields)
{
    Console.WriteLine(field);
}

Console.WriteLine(preconfiguredReportfromStrategy.Name);

foreach (var field in preconfiguredReportfromStrategy.PreconfiguredFields)
{
    Console.WriteLine(field);
}


// ---------------------------------------------------------------------
//----------------------Adapter approach--------------------------------

//Using Factory service with a Strategy client with the addition of an adapter

CustomReportStrategy customReportStrategyTwo = new();


ReportsFactoryAdapterForStrategyClient adapter = new();
 

customReportFromStrategy = (CustomReport)customReportStrategy.GenerateReport(22, 8993, 9903);

// Using an Adapter to calle a service with an INCOMPATIBLE interface

var preconfiguredReportfromAdapter = adapter
	.CreatePreconfiguredReportFromFactoryService((int)ReportTypeEnums.PreconfiguredReport, reportGeneratorService);


Console.WriteLine();
Console.WriteLine("-------------ADAPTER----------------------");
Console.WriteLine(customReportFromStrategy.Name);

foreach (var field in customReportFromStrategy.CustomFields)
{
    Console.WriteLine(field);
}

Console.WriteLine(preconfiguredReportfromAdapter.Name);




