using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystemDemoSoft.DAL.Gateway;

namespace LibraryManagementSystemDemoSoft.BLL
{
    class RequestManager
    {
        RequestGateway aRequestGateway = new RequestGateway();
        BookGateway aBookGateway = new BookGateway();

        public string SaveToTemporaryReq(DAL.DAO.Request aRequest)
        {
            if (aBookGateway.CheckIfCopyExist(aRequest) != 0)
            {
                if (aRequestGateway.CheckIfThisReqApproved(aRequest) != "approved" && aRequestGateway.CheckIfThisReqApproved(aRequest) != "returned")
                {
                    //
                    if (aRequestGateway.RequstedItem(aRequest) < 3 - aRequestGateway.ApprovedItem(aRequest))
                    {
                        if (aRequestGateway.CheckIfThisReqExist(aRequest) == false)
                        {
                            if (aRequestGateway.SaveToTemporaryReq(aRequest))
                            {
                                return "Request updated";
                            }
                            else
                            {
                                return "Not Added";
                            }
                        }
                        else
                        {
                            return "already requested";
                        }
                    }
                    else
                    {
                        return "You have already requested 3 Book or your alloted book slot are filled. Please return to request again";
                    }
                    //
                }
                else
                {
                    return "You have already read this Book";
                }
            }
            else
            {
                return "Book is not available now, please try later";
            }
        }

        public List<DAL.DAO.Request> LoadTemporaryRequestedBookGridView(string readerID)
        {
            return aRequestGateway.LoadTemporaryRequestedBookGridView(readerID);
        }

        public string ClearThisBookFromTempReq(string bookID, string readerID)
        {
            if (aRequestGateway.ClearThisBookFromTempReq(bookID, readerID))
            {
                return "Cleared";
            }
            else
            {
                return "Something Wrong";
            }
        }

        public List<DAL.DAO.Request> LoadRequestListForAdminGridView()
        {
            return aRequestGateway.LoadRequestListForAdminGridView();
        }

        public string ApproveThisrequest(DAL.DAO.Request aRequest)
        {

            if (aRequestGateway.ApproveThisrequest(aRequest) && aBookGateway.UpdateBookQuantityForApprove(aRequest))
            {
                if (aRequestGateway.UpdateReturningDate(aRequest))
                {
                    return "Request approved for '" + aRequest.ReqReaderID + "'";
                }
                return "Somthing Wrong";
            }
            return "Somthing Wrong";
        }

        public List<DAL.DAO.Request> LoadApprovedBoolGridView(string readerID)
        {
            return aRequestGateway.LoadApprovedBoolGridView(readerID);
        }

        public string DenyThisrequest(DAL.DAO.Request aRequest)
        {
            if (aRequestGateway.DenyThisrequest(aRequest))
            {
                return "Request Denied for '" + aRequest.ReqReaderID + "'";
            }
            return "Somthing Wrong";
        }


        public string ReturnThisBook(DAL.DAO.Request cRequest)
        {
            
            TimeSpan returnDate = DateTime.Today - aRequestGateway.TakeReturnDate(cRequest);
            //int fee = 30;

            if (aRequestGateway.TakeReturnDate(cRequest) > DateTime.Today)
            {
                if (aRequestGateway.ReturnThisBook(cRequest) && aBookGateway.UpdateBookQuantityForReturn(cRequest))
                {
                    return "Book returned";
                }
                return "return failed";
            }

            else if (aRequestGateway.TakeReturnDate(cRequest) < DateTime.Today)
            {
                int fee = 30 * returnDate.Days;
                if (cRequest.Fee == fee)
                {
                    if (aRequestGateway.ReturnThisBook(cRequest) && aRequestGateway.UpdateFee(cRequest))
                    {
                        return "Book returned";
                    }
                    return "Error occured";
                }
                return "Insert fee " +fee+ " taka";
            }

            else
            {
                return "Somthing Wrong";
            }
        }
    }
}
