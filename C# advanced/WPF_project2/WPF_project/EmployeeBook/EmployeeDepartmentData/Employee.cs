﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeeDepartmentData
{
    //сущность сотрудников: имя, фамилия, отдел, должность
    //public struct EmployeeName 
    //{
    //    private string firstName;
    //    private string lastName;

    //    public EmployeeName(string firstName, string lastName)
    //    {
    //        this.firstName = firstName;
    //        this.lastName = lastName;
    //    }

    //    public string FirstName => firstName;
    //    public string LastName => lastName;

        

    //    public override string ToString()
    //    {
    //        return $"{firstName} {lastName}";
    //    }
    //}

    public class Employee : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _firstName;
        private string _lastName;
        private DepartmentCategory _department = DepartmentCategory.Department1;
        private string _job;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = " ")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string FirstName 
        { 
            get => _firstName; 
            set 
            {
                _firstName = value;
                NotifyPropertyChanged();
            } 
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        public DepartmentCategory Department 
        { 
            get => _department; 
            set 
            { 
                _department = value;
                NotifyPropertyChanged();
            }
        }
        public string Job 
        { 
            get => _job;
            set
            {
                _job = value;
                NotifyPropertyChanged();
            }
        }

        public Employee(string firstName, string lastName, DepartmentCategory department, string jobName)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Job = jobName;
        }

        public override string ToString()
        {
            return $"name: {FirstName}, lastname: {LastName}, department: {Department}, job title: {Job}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
