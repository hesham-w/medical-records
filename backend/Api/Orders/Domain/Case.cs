namespace Api.Orders
{
    enum WorkflowType
    {
        Authorization,
        Subpoena,
        CreateCase,
        SmartOrg,
        SpecialRequest
    }

    public abstract class Case
    {
        public Guid Id { get; private set; }

        public bool Cancelled { get; private set; }

        public string PlaintiffName { get; private set; }

        public string DefendantName { get; private set; }

        public List<CasePart> Parts { get; private set; }

        public List<CaseParty> Parties { get; private set; }

        public Guid LeadAttorneyContactId { get; set; }

        public Case(string plaintiffName, string defendantName, List<CasePart> parts, List<CaseParty> parties, Guid leadAttorneyContactId)
        {
            PlaintiffName = plaintiffName;
            DefendantName = defendantName;
            Parts = parts;
            Parties = parties;
            LeadAttorneyContactId = leadAttorneyContactId;

            Id = Guid.NewGuid();
        }

        public void AddPart(Guid contactId, CasePart part)
        {
            if (Cancelled)
            {
                throw new InvalidOperationException("Cannot add a part to a cancelled case.");
            }

            Parts.Add(part);
        }

        public void AddParties(CaseParty party)
        {
            if (Cancelled)
            {
                throw new InvalidOperationException("Cannot add a party to a cancelled case.");
            }

            Parties.Add(party);
        }

        public void CancelCase(Guid contactId)
        {
            Cancelled = true;
        }

    }

    public class CasePart
    {
        public Guid Id { get; set; }
        public Guid CustodianId { get; set; }
        public Guid RecordTypeId { get; set; }
        public Guid CaseId { get; set; }

        public CasePart(Guid custodianId, Guid recordTypeId, Guid caseId)
        {
            CustodianId = custodianId;
            RecordTypeId = recordTypeId;
            CaseId = caseId;

            Id = Guid.NewGuid();
        }
    }

    public class CaseParty
    {
        public Guid Id { get; private set; }
        public Guid ContactId { get; private set; }
        public Guid CaseId { get; private set; }
        public CaseParty(Guid contactId, Guid caseId)
        {
            ContactId = contactId;
            CaseId = caseId;

            Id = Guid.NewGuid();
        }
    }


}