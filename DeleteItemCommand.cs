﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands
{
    public class DeleteItemCommand : Command
    {
        public DeleteItemCommand(Guid id, int version) : base(id, version)
        {
        }
    }
}
