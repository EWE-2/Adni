using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace Adni.WebApi.Helpers
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;
        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => _provider = provider;

        /**<summary>
        * Le comportement <c>Configure</c> ajoute une documentation pour toute version de l'api decouverte
        * </summary>
        */
        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
        }

        private OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = "Adni",
                Version = description.ApiVersion.ToString(),
                Description = "Service web de l'application de gestion des stage et suivi de l'insertion professionnelle",
                Contact = new OpenApiContact
                {
                    Name = "LightDigit",
                    Email = "EWANE.EWANE@hotmail.com",
                    Url = new Uri("https://adniapp.cm/support")
                },
            };

            if (description.IsDeprecated)
                info.Description += "<strong>Cette version de l'api Adni n'est plus prise en charge</strong>";

            return info;
        }
    }
}
