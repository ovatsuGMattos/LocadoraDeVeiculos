using LocadoraDeVeiculos.Infra.Configuracoes;
using LocadoraDeVeiculos.Infra.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Configuracoes
{
    public static class Configuracao
    {
        private static readonly Dictionary<string, string> camposIniciais = new Dictionary<string, string>()
        {
            {"precoGasolina", "0" },
                {"precoGas", "0" },
                {"precoDieses", "0" },
                {"precoAlcool", "0" },

                {"horaAbertura", new TimeSpan(8, 0, 0).ToString() },
                {"horaFechamento", new TimeSpan(18, 0, 0).ToString() },

                {"abreNoSabado", "false" },
                {"abreNoDomingo", "false" },

                {"logDetalhado", "false" },
                {"ativarLog", "true" }
        };

        private static AppConfigController appConfigController;

        static Configuracao()
        {
            appConfigController = new AppConfigController(camposIniciais);
        }

        public static double PrecoGasolina
        {
            get
            {
                double preco = Convert.ToDouble(appConfigController.Ler("precoGasolina"));
                Serilog.Log.Logger.Aqui().Information($"Lendo o preço da gasolina, valor lido:{preco}");
                return preco;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando o preço da gasolina, valor setado:{value}");
                appConfigController.Setar("precoGasolina", value);
            }
        }
        public static double PrecoGas
        {
            get
            {
                double preco = Convert.ToDouble(appConfigController.Ler("precoGas"));
                Serilog.Log.Logger.Aqui().Information($"Lendo o preço do gás, valor lido:{preco}");
                return preco;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando o preço do gás, valor setado:{value}");
                appConfigController.Setar("precoGas", value);
            }
        }
        public static double PrecoDiesel
        {
            get
            {
                double preco = Convert.ToDouble(appConfigController.Ler("precoDieses"));
                Serilog.Log.Logger.Aqui().Information($"Lendo o preço do diesel, valor lido:{preco}");
                return preco;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando o preço do diesel, valor setado:{value}");
                appConfigController.Setar("precoDieses", value);
            }
        }
        public static double PrecoAlcool
        {
            get
            {
                double preco = Convert.ToDouble(appConfigController.Ler("precoAlcool"));
                Serilog.Log.Logger.Aqui().Information($"Lendo o preço do álcool, valor lido:{preco}");
                return preco;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando o preço do álcool, valor setado:{value}");
                appConfigController.Setar("precoAlcool", value);
            }
        }
        public static TimeSpan HoraAbertura
        {
            get
            {
                TimeSpan hora = TimeSpan.Parse(appConfigController.Ler("horaAbertura"));
                Serilog.Log.Logger.Aqui().Information($"Lendo a hora de abertura, valor lido:{hora}");
                return hora;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando a hora de abertura, valor setado:{value}");
                appConfigController.Setar("horaAbertura", value);
            }
        }
        public static TimeSpan HoraFechamento
        {
            get
            {
                TimeSpan hora = TimeSpan.Parse(appConfigController.Ler("horaFechamento"));
                Serilog.Log.Logger.Aqui().Information($"Lendo a hora de fechamento, valor lido:{hora}");
                return hora;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando a hora de fechamento, valor setado:{value}");
                appConfigController.Setar("horaFechamento", value);
            }
        }
        public static bool AbreNoSabado
        {
            get
            {
                bool abre = Convert.ToBoolean(appConfigController.Ler("abreNoSabado"));
                Serilog.Log.Logger.Aqui().Information($"Lendo se abre no sábado, valor lido:{abre}");
                return abre;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando se abre no sábado, valor setado:{value}");
                appConfigController.Setar("abreNoSabado", value);
            }
        }

        public static bool AbreNoDomingo
        {
            get
            {
                bool abre = Convert.ToBoolean(appConfigController.Ler("abreNoDomingo"));
                Serilog.Log.Logger.Aqui().Information($"Lendo se abre no domingo, valor lido:{abre}");
                return abre;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando se abre no domingo, valor setado:{value}");
                appConfigController.Setar("abreNoDomingo", value);
            }
        }

        public static bool LogDetalhado
        {
            get
            {
                bool valor = Convert.ToBoolean(appConfigController.Ler("logDetalhado"));
                Serilog.Log.Logger.Aqui().Information($"Lendo log  detalhado, valor lido:{valor}");
                return valor;
            }
            set
            {
                Serilog.Log.Logger.Aqui().Information($"Setando se o log é detalhado, valor setado:{value}");
                appConfigController.Setar("logDetalhado", value);
            }
        }
    }



}
