namespace Services.DTO
{
    public class CommentDTO
    {
        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string CommentedEssenceId { get; set; }
        public string Text { get; set; }
    }
}
