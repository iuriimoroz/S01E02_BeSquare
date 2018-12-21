using System.Collections.Generic;

namespace S01E02_BeSquare
{
    /// <summary>
    /// A factory that cuts material into squares. Think of, for example, cutting carpet.
    /// </summary>
    public interface ISquareFactory
    {
        /// <summary>
        /// Gets or sets how big an output square shall be on each side.
        /// </summary>
        int SquareSize { get; set; }

        /// <summary>
        /// Adds some material to the factory. The material will be cut to squares immediately
        /// and the squares are later given to the caller via GetSquares().
        /// </summary>
        /// <remarks>
        /// The SquareSize used at the time of this call is what is used for creating squares.
        /// If you change SquareSize after this call, the size of already-made squares will not change.
        /// 
        /// Any excess material that cannot be made into squares of the right size is thrown away.
        /// </remarks>
        void AddMaterial(int width, int height);

        /// <summary>
        /// Gets the number of squares that are ready and waiting to be delivered to the caller.
        /// </summary>
        int SquaresReadyForDelivery { get; }

        /// <summary>
        /// Gets a generator that moves ready-made squares from the factory to the caller.
        /// All squares are guaranteed to be of the size that was ordered.
        /// </summary>
        IEnumerable<Rectangle> GetSquares();
    }
}
