using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DeleteAccountFacade
    {
        private readonly AdminSystem _admin;
        private readonly AssignmentSystem _assignment;
        private readonly ListingSystem _listing;

        public DeleteAccountFacade(AdminSystem admin,AssignmentSystem assignment,ListingSystem listing)
        {
            _admin = admin;
            _assignment = assignment;
            _listing = listing;
        }

        public string DeleteAccount()
        {
            var myResult = _admin.DeleteAccount();

            myResult += _assignment.ResetAssign();

            myResult += _listing.DeleteListing();

            return myResult;
        }
    }
}
