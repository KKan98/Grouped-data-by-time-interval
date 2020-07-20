using System;
using System.Collections.Generic;
using System.Text;

namespace GroupedData.Application.Features.DeleteActivity
{
    public class DeleteActivityCommand
    {
        public DeleteActivityCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
