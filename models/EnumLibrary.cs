﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_29_b_exceptions.models
{
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum SeverityLevel
    {
        Low = 1,
        Medium,
        High,
        Critical
    }

    public enum StatusCode
    {
        Ok = 200,
        NotFound = 404,
        InternalServerError = 500
    }

    public enum LightState
    {
        Red,
        Yellow,
        Green,
        Unknown
    }

    public enum PaymentMethod
    {
        [Description("Credit Card")]
        CreditCard,
        PayPal,
        [Description("Bank Transfer")]
        BankTransfer
    }

    public class Order
    {
        public enum OrderStatus
        {
            Pending, Shipped, Delivered, Cancelled
        }
        public OrderStatus Status { get; set; }
    }


}
