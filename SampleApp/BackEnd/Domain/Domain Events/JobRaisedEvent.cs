using BackEnd.Domain;
namespace BackEnd.Domain.Domain_Events
{
	public class JobRaisedEvent : DomainEvent
	{
		public JobRaisedEvent(Guid jobId, Guid clientId, Guid siteId, JobCategory Category, string desc)
		{
			JobId = jobId;
			ClientId = clientId;
			SiteId = siteId;
			JobCategory = category;
			Desc = desc;

		}

		public Guid ClientId { get; }
		public Guid SiteId { get; }
		public JobCategory category { get; }
		public DateOnly ScheduledDate { get; }
		public string desc { get; }
		public Guid JobId { get; }
	}
}