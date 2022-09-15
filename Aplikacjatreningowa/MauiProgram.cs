namespace Aplikacjatreningowa;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("CentraNo2-Medium.ttf", "CentraNo2-Medium");
                fonts.AddFont("CentraNo2-Extrabold.ttf", "CentraNo2-Extrabold");
            });

		return builder.Build();
	}
}
