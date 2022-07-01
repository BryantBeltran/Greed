namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Mineral : Actor
    {
        private int points = 0;

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Mineral(int points)
        {
            this.points = points;
        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message.</returns>
        public int GetPoints()
        {
            return points;
        }

        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        
    }
}