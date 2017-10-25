namespace Kata
{
    public class Block
    {
        private int width;
        private int length;
        private int height;

        public Block(int[] block)
        {
            this.width = block[0];
            this.length = block[1];
            this.height = block[2];
        }

        /// <summary>
        /// return the width of the `Block`
        /// </summary>
        /// <returns></returns>
        public int GetWidth()
        {
            return width;
        }

        /// <summary>
        /// return the length of the `Block`
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return length;
        }

        /// <summary>
        /// return the height of the `Block`
        /// </summary>
        /// <returns></returns>
        public int GetHeight()
        {
            return height;
        }

        /// <summary>
        /// return the volume of the `Block`
        /// </summary>
        /// <returns></returns>
        public int GetVolume()
        {
            return length * width * height;
        }

        /// <summary>
        /// return the volume of the `Block`
        /// </summary>
        /// <returns></returns>
        public int GetSurfaceArea()
        {
            return 2 * (length * width + width * height + length * height);
        }
    }
}
