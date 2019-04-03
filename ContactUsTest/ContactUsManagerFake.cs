using ContactUs.Models;
using ContactUs.Models.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactUsTest
{
    class ContactUsManagerFake : IDataRepository<ContactUsMessage>
    {

        List<ContactUsMessage> _databaseMock;

        public ContactUsManagerFake()
        {
            _databaseMock = new List<ContactUsMessage>();
        }

        

        public void Add(ContactUsMessage entity)
        {
            _databaseMock.Add(entity);
        }

        public void Delete(ContactUsMessage entity)
        {
            _databaseMock.Remove(entity);
        }

        public ContactUsMessage Get(long id)
        {
            return _databaseMock.Find(message => message.MessageId == id);
        }

        public IEnumerable<ContactUsMessage> GetAll()
        {
            return _databaseMock;
        }

        public void Update(ContactUsMessage dbEntity, ContactUsMessage entity)
        {
            _databaseMock[_databaseMock.FindIndex(message => message.MessageId == dbEntity.MessageId)] = entity;
        }
    }
}
