namespace Api.Orders
{
    internal static class CaseAccessRules
    {
        internal static bool HasCaseAccess(Case @case, Guid contactId)
        {
            var hasCaseAccess = @case.Parties.Any(p => p.ContactId == contactId) || contactId == @case.LeadAttorneyContactId;

            return hasCaseAccess;
        }
    }
}
