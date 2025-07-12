﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public decimal Value { get; private set; }
        public decimal AmountPaid { get; private set; }
        public bool Paid { get; set; }
        public DateTime Date { get; private set; }
        public string Description { get; set; }
        public Guid ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public Payment() { }

        public Payment(decimal value, decimal amountPaid, bool paid, DateTime date, string description, Guid scheduleId)
        {
            SetValue(value);
            SetAmountPaid(amountPaid);
            Paid = paid;
            SetDate(date);
            Description = description;
            ScheduleId = scheduleId;
        }
        public void SetValue(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Invalid Value {value}");
            }
            Value = value;
        }
        public void SetAmountPaid(decimal amountPaid)
        {
            if (amountPaid < 0)
            {
                throw new ArgumentException($"Invalid Amount Paid {amountPaid}");

            }
            AmountPaid = amountPaid;
        }
        public void SetDate(DateTime date)
        {
            if (date < DateTime.MinValue)
            {
                throw new ArgumentException($"Invalid Date {date.ToString()}");
            }
            Date = date;
        }
    }
}
