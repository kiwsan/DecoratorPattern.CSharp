﻿using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorys
{
    public class SmsRepository : INotificationRepository<SmsRepository>
    {

        public void Send()
        {
            Console.WriteLine("SMS Sending.");
        }

    }
}
