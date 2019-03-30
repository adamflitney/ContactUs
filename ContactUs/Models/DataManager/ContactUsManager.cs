using ContactUs.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUs.Models.DataManager
{
    public class ContactUsManager : IDataRepository<ContactUsMessage>
    {

        readonly ContactUsContext _contactUsContext;

        public ContactUsManager(ContactUsContext context)
        {
            _contactUsContext = context;
        }

        public IEnumerable<ContactUsMessage> GetAll()
        {
            return _contactUsContext.ContactUsMessages.ToList();
        }

        public ContactUsMessage Get(long id)
        {
            return _contactUsContext.ContactUsMessages.FirstOrDefault(m => m.MessageId == id);
        }


        public void Add(ContactUsMessage entity)
        {
            _contactUsContext.ContactUsMessages.Add(entity);
            _contactUsContext.SaveChanges();
        }

        public void Update(ContactUsMessage dbEntity, ContactUsMessage entity)
        {
            dbEntity.senderName = entity.senderName;
            dbEntity.emailAddress = entity.emailAddress;
            dbEntity.message = entity.message;

            _contactUsContext.SaveChanges();
        }

        public void Delete(ContactUsMessage entity)
        {
            _contactUsContext.ContactUsMessages.Remove(entity);
            _contactUsContext.SaveChanges();
        }
    }
}
