using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirstLook
{
    public class AggregateEntity<TId>
    {
        public TId Id { get; protected set; }
    }
}
