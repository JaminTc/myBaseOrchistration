﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBaseOrchestration.API.ServiceModel.Dtos;
using ServiceStack;

namespace MyBaseOrchestration.API.ServiceModel.Messages
{
    public class ReadPersonResponse : IHasResponseStatus
    {
        public Person Person { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
