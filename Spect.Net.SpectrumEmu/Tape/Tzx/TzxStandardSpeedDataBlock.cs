﻿using System.IO;

namespace Spect.Net.SpectrumEmu.Tape.Tzx
{
    /// <summary>
    /// Represents the standard speed data block in a TZX file
    /// </summary>
    public class TzxStandardSpeedDataBlock : TzxDataBlockBase
    {
        /// <summary>
        /// Pause after this block
        /// </summary>
        public ushort PauseAfter { get; set; }

        /// <summary>
        /// Lenght of block data
        /// </summary>
        public ushort DataLenght { get; set; }

        /// <summary>
        /// Block Data
        /// </summary>
        public byte[] Data { get; set; }

        public TzxStandardSpeedDataBlock()
        {
            PauseAfter = 1000;
        }

        #region Overrides of TzxDataBlockBase

        /// <summary>
        /// The ID of the block
        /// </summary>
        public override int BlockId => 0x10;

        /// <summary>
        /// Reads the content of the block from the specified binary stream.
        /// </summary>
        /// <param name="reader">Stream to read the block from</param>
        public override void ReadFrom(BinaryReader reader)
        {
            PauseAfter = reader.ReadUInt16();
            DataLenght = reader.ReadUInt16();
            Data = reader.ReadBytes(DataLenght);
        }

        /// <summary>
        /// Writes the content of the block to the specified binary stream.
        /// </summary>
        /// <param name="writer">Stream to write the block to</param>
        public override void WriteTo(BinaryWriter writer)
        {
            writer.Write(PauseAfter);
            writer.Write(DataLenght);
            writer.Write(Data);
        }

        #endregion
    }
}