using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    [DeveloperInfo2("Данил", "ООО Легострой")] // Атрибут для вывода инфы
    internal class Building
    {
        private uint id;   
        private uint high;
        private uint level;
        private uint numberOfApartament;
        private uint entrance;
        public uint Id
        {
            get { return id; }
        }
        public uint High
        {
            get { return high; }
            set { high = value; }
        }
        public uint Level
        {
            get { return level; }
            set { level = value; }
        }
        public uint NumberOfApartament
        {
            get { return numberOfApartament; }
            set { numberOfApartament = value; }
        }
        public uint Entrance
        {
            get { return entrance; }
            set { entrance = value; }
        }
        public Building(uint high, uint level, uint numberOfApartament, uint entrance)
        {
            this.high = high;
            this.level = level;
            this.numberOfApartament = numberOfApartament;
            this.entrance = entrance;
        }
        public uint CalculateHighLevel() // Высота этажа
        {
            return High / Level;
        }
        public uint NumberOfApartamentsInEnrtance() // Количество квартир в подъезде
        {
            return NumberOfApartament / Entrance;
        }
        public uint NumberOfApartamentsInLevel() // Количество квартир на этаже
        {
            return (NumberOfApartament / Level) / Entrance;
        }
        public override string ToString() => $" Высота этажа - {CalculateHighLevel()},\n " +
                                             $" Количество квартир в подъезде - {NumberOfApartamentsInEnrtance()}\n" +
                                             $" Количество квартир на этаже - {NumberOfApartamentsInLevel()} \n" +
                                             $"Номер здания - {Id},\n" +
                                             $" Высота здания - {High},\n " +
                                             $"Этажность - {Level},\n" +
                                             $" Количество квартир - {NumberOfApartament},\n" +
                                             $" Количество подъездов - {Entrance}.\n ";
    }
}
