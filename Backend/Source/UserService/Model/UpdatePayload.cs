namespace UserService.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Shared.Interface;

    /// <summary>
    /// Payload for Update Command
    /// </summary>
    public class UpdatePayload : IModel
    {
        /// <summary>
        /// Gets or sets the user's id
        /// </summary>
        /// <returns> The user's id </returns>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the changed fields
        /// </summary>
        /// <returns> The changed fields </returns>
        [Required]
        public Dictionary<string, string> Change { get; set; }
    }
}