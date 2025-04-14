using Microsoft.VisualBasic;
using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class ContactInfoViewModel
    {
        private List<ContactInfo> _cinfo = new List<ContactInfo>
        {
            new ContactInfo
            {
                Address = "Tanta, Egypt",
                Phone = "+201202155490",
                Email = "amin.kh.ragab@gmail.com"
            }
        };

        public List<ContactInfo> Cinfo => _cinfo;
    }
}
