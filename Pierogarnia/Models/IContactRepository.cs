﻿using System.Linq;

namespace Pierogarnia.Models
{
    public interface IContactRepository
    {
        IQueryable<Contact> contacts { get; }
        void addIssue(int contactId, Issue issue);
    }
}