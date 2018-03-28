namespace MiniAiCup.Agario
{
    public class GameConfiguration
    {
        /// размеры мира 
        public int GameWidth { get; set;} 
        /// размеры мира 
        public int GameHeight { get; set;}
        /// масса еды (float) (меняется от 1.0 до 4.0)
        public int GameTicks { get; set;}
        /// масса еды (float) (меняется от 1.0 до 4.0)
        public int FoodMass { get; set; }
        /// максимальное количество фрагментов у одного игрока (int) (от 4 до 16);
        public int MaxFragmentsCount { get; set; }
        /// кол-во тиков после деления или взрыва, когда можно слить фрагменты (int) (от 150 до 500)
        public int TicksTilFusion { get; set; }
        /// критическая масса, по достижению которой вирус поделится (float) (от 50.0 до 100.0)
        public int VirusSplitMass { get; set; }
        /// вязкость среды, от которой зависит скорость замедления вирусов, выбросов и фрагментов после деления (float) (от 0.05 - наименьшая вязкость, до 0.5)
        public int Viscosity { get; set; }
        /// параметр регулировки инерции (насколько быстро изменяется вектор скорости при смене направления) (float) (от 1.0 - наибольшая инерция, до 20.0)
        public int InertionFactor { get; set; }
        /// параметр регулировки максимальной скорости (float) (от 25.0 до 100.0 - космические скорости)
        public int SpeedFactor { get; set; }
    }
}