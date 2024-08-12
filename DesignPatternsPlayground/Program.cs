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

