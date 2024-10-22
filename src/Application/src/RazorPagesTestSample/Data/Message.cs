using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        /// <value>
        /// The text of the message, which is required and must be a string with a maximum length of 250 characters.
        /// </value>
        /// <exception cref="ValidationException">
        /// Thrown when the text exceeds the 250 character limit.
        /// </exception>
        [Required]
        [DataType(DataType.Text)]
        [StringLength(250, ErrorMessage = "There's a 250 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
