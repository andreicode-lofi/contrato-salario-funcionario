using System;
using System.Collections.Generic;
using System.Text;
using Corse.Entities.Enums;
using Corse.Entities;

namespace Corse.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLvel Level { get; set; }
        public double BaseSalary { get; set; }
        public Depertment Depertment { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLvel level, double baseSalary, Depertment depertment)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Depertment = depertment;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValeu();
                }
            }

            return sum;
        }

    }
}
