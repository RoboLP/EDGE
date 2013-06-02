﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LibTwoTribes.Util;

namespace LibTwoTribes
{
    public class EMAAnimationBlock
    {
        private int m_ProbablyTextureId;
        private KeyframeBlock m_ScaleU;
        private KeyframeBlock m_ScaleV;
        private KeyframeBlock m_Rotation;
        private KeyframeBlock m_TranslationU;
        private KeyframeBlock m_TranslationV;

        public int ProbablyTextureId { get { return m_ProbablyTextureId; } set { m_ProbablyTextureId = value; } }
        public KeyframeBlock ScaleU { get { return m_ScaleU; } set { m_ScaleU = value; } }
        public KeyframeBlock ScaleV { get { return m_ScaleV; } set { m_ScaleV = value; } }
        public KeyframeBlock Rotation { get { return m_Rotation; } set { m_Rotation = value; } }
        public KeyframeBlock TranslationU { get { return m_TranslationU; } set { m_TranslationU = value; } }
        public KeyframeBlock TranslationV { get { return m_TranslationV; } set { m_TranslationV = value; } }

        private EMAAnimationBlock(Stream stream)
        {
            using (TTBinaryReader br = new TTBinaryReader(stream))
            {
                m_ProbablyTextureId = br.ReadInt32();
                m_ScaleU = new KeyframeBlock(stream);
                m_ScaleV = new KeyframeBlock(stream);
                m_Rotation = new KeyframeBlock(stream);
                m_TranslationU = new KeyframeBlock(stream);
                m_TranslationV = new KeyframeBlock(stream);
            }
        }

        public EMAAnimationBlock()
        {
            m_ProbablyTextureId = 0;
            m_ScaleU = new KeyframeBlock(1);
            m_ScaleV = new KeyframeBlock(1);
            m_Rotation = new KeyframeBlock(0);
            m_TranslationU = new KeyframeBlock(0);
            m_TranslationV = new KeyframeBlock(0);
        }

        public static EMAAnimationBlock FromStream(Stream stream)
        {
            return new EMAAnimationBlock(stream);
        }

        public void Save(Stream stream)
        {
            using (TTBinaryWriter bw = new TTBinaryWriter(stream))
            {
                bw.Write(m_ProbablyTextureId);
                m_ScaleU.Save(stream);
                m_ScaleV.Save(stream);
                m_Rotation.Save(stream);
                m_TranslationU.Save(stream);
                m_TranslationV.Save(stream);
            }
        }
    }
}