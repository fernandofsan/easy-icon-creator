using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace EasyIconCreator
{
    public class TileConfiguration : INotifyPropertyChanged
    {
        [JsonIgnore]
        private const string TileConfigurationFile = "TileConfiguration.json";

        [JsonIgnore]
        private static TileConfiguration instance { get; set; }

        [JsonIgnore]
        public static TileConfiguration Instance {
            get {
                if (instance == null)
                {
                    if (!File.Exists(TileConfigurationFile))
                        File.WriteAllText(TileConfigurationFile, JsonConvert.SerializeObject(new TileConfiguration()));

                    try
                    {
                        instance = JsonConvert.DeserializeObject<TileConfiguration>(File.ReadAllText(TileConfigurationFile));
                    }
                    catch (Exception)
                    {
                        File.WriteAllText(TileConfigurationFile, JsonConvert.SerializeObject(new TileConfiguration()));

                        instance = new TileConfiguration();
                    }
                }

                return instance;
            }
        }


        public TileConfiguration()
        {
            if (TileSizes == null)
                TileSizes = new List<TileSize>{
                                new TileSize(40, 40),
                                new TileSize(200, 120),
                                new TileSize(200, 140),
                                new TileSize(200, 400)
                            };
        }

        private string iconsPath;
        public string IconsPath
        {
            get { return iconsPath; }
            set {
                iconsPath = value;

                OnPropertyChanged("IconsPath");
                OnPropertyChanged("hasIconPath");
            }
        }

        private List<TileSize> tileSizes { get; set; }
        public List<TileSize> TileSizes {
            get { return tileSizes; }
            set {
                tileSizes = value;

                OnPropertyChanged("TileSizes");
            }
        }

        public bool hasIconPath { get { return !string.IsNullOrEmpty(IconsPath); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        /// <summary>
        /// Atualiza arquivo com novas configurações
        /// </summary>
        public void Save()
        {
            File.WriteAllText(TileConfigurationFile, JsonConvert.SerializeObject(instance));
        }
    }

}
