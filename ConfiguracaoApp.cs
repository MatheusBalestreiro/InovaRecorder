using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace InovaRecorder
{
    public class ConfiguracaoApp
    {
        public string PastaGravacoes { get; set; }
    }

    public class GerenciadorConfiguracoes
    {
        private static string caminhoArquivoConfig = Path.Combine(Application.StartupPath, "configuracoes.json");

        public static ConfiguracaoApp CarregarConfiguracoes()
        {
            try
            {
                if (File.Exists(caminhoArquivoConfig))
                {
                    string json = File.ReadAllText(caminhoArquivoConfig);
                    return JsonSerializer.Deserialize<ConfiguracaoApp>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar configurações: {ex.Message}");
            }

            // Configuração padrão: Pasta do aplicativo + \Gravacoes
            return new ConfiguracaoApp
            {
                PastaGravacoes = Path.Combine(Application.StartupPath, "Gravacoes")
            };
        }

        public static void SalvarConfiguracoes(ConfiguracaoApp config)
        {
            try
            {
                string json = JsonSerializer.Serialize(config, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(caminhoArquivoConfig, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar configurações: {ex.Message}");
            }
        }
    }
}