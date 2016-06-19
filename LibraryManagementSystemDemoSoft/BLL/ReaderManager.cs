using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemDemoSoft.DAL.Gateway;

namespace LibraryManagementSystemDemoSoft.BLL
{
    class ReaderManager
    {
        ReaderGateway aReaderGateway = new ReaderGateway();

        public string SaveThisReader(DAL.DAO.Reader aReader)
        {
            if (aReaderGateway.CheckIfExist(aReader) == false)
            {
                if (aReaderGateway.SaveThisReader(aReader))
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
                return "This id is exist";
            }
        }

        public bool PermitToLogin(DAL.DAO.Reader aReader)
        {
            if (aReaderGateway.PermitToLogin(aReader))
            {
                return true;
            }
            return false;
        }

        public List<DAL.DAO.Reader> LoadReaderGridView()
        {
            return aReaderGateway.LoadReaderGridView();
        }

        public string LoadReaderInfo(string readerID)
        {
            return aReaderGateway.LoadReaderInfo(readerID);
        }
    }
}
