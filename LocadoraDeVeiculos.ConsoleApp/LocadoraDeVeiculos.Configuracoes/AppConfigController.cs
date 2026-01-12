using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.Configuracoes
{
    internal class AppConfigController
    {
        private Dictionary<string, string> camposIniciais;

        public AppConfigController(Dictionary<string, string> camposIniciais)
        {
            this.camposIniciais = camposIniciais;
        }

        internal class AppConfigControler(Dictionary<string, string> camposIniciais)
        {
            AdicionarCamposCasoNaoExista(camposIniciais);
        }

        private void AdicionarCamposCasoNaoExista(Dictionary<string, string> campos)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            foreach (var campo in campos)
            {
                if (settings[campo.Key] == null)
                {
                    settings.Add(campo.Key, campo.Value);
                }
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        public string Ler(string chave) => ConfigurationManager.AppSettings[chave];

        public void Setar(string chave, object valor)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[chave] != null)
                return;
            settings[chave].Value = valor.ToString();

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        }
    }
}
