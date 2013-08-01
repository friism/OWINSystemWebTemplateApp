using Owin;

namespace OWINSystemWebTemplateApp
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseWelcomePage("/");
		}
	}
}
