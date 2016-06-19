using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemDemoSoft.DAL.Gateway;

namespace LibraryManagementSystemDemoSoft.BLL
{
    class BookManager
    {
        BookGateway aBookGateway = new BookGateway();

        public string SaveThisBook(DAL.DAO.Book aBook)
        {

            if (aBookGateway.CheckIfExist(aBook) == false)
            {
                if (aBookGateway.SaveThisReader(aBook))
                {
                    return "Saved";
                }
                else
                {
                    return "not saved";
                }
            }
            else
            {
                return "This BOOK is exist";
            }
        }

        public List<DAL.DAO.Book> LoadBookGridView()
        {
            return aBookGateway.LoadBookGridView();
        }
    }
}
