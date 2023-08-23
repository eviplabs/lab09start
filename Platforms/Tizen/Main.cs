using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace LAB09_MAUI_DataBindingLab;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
