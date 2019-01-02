using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvitationV2.Data.Entities;

namespace InvitationV2.Data
{
    //DbContext knows how to execute queries to a datastore
    public class InvitationContext : DbContext
    {
        public DbSet<RSVP> RSVPs { get; set; }
    }
}
