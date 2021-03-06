// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Error returned by <see
    /// cref="Dropbox.Api.Team.Routes.TeamRoutes.LinkedAppsRevokeLinkedAppAsync" />.</para>
    /// </summary>
    public class RevokeLinkedAppError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RevokeLinkedAppError> Encoder = new RevokeLinkedAppErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RevokeLinkedAppError> Decoder = new RevokeLinkedAppErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeLinkedAppError" />
        /// class.</para>
        /// </summary>
        public RevokeLinkedAppError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AppNotFound</para>
        /// </summary>
        public bool IsAppNotFound
        {
            get
            {
                return this is AppNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AppNotFound, or <c>null</c>.</para>
        /// </summary>
        public AppNotFound AsAppNotFound
        {
            get
            {
                return this as AppNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MemberNotFound</para>
        /// </summary>
        public bool IsMemberNotFound
        {
            get
            {
                return this is MemberNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MemberNotFound, or <c>null</c>.</para>
        /// </summary>
        public MemberNotFound AsMemberNotFound
        {
            get
            {
                return this as MemberNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RevokeLinkedAppError" />.</para>
        /// </summary>
        private class RevokeLinkedAppErrorEncoder : enc.StructEncoder<RevokeLinkedAppError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RevokeLinkedAppError value, enc.IJsonWriter writer)
            {
                if (value is AppNotFound)
                {
                    WriteProperty(".tag", "app_not_found", writer, enc.StringEncoder.Instance);
                    AppNotFound.Encoder.EncodeFields((AppNotFound)value, writer);
                    return;
                }
                if (value is MemberNotFound)
                {
                    WriteProperty(".tag", "member_not_found", writer, enc.StringEncoder.Instance);
                    MemberNotFound.Encoder.EncodeFields((MemberNotFound)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RevokeLinkedAppError" />.</para>
        /// </summary>
        private class RevokeLinkedAppErrorDecoder : enc.UnionDecoder<RevokeLinkedAppError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RevokeLinkedAppError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RevokeLinkedAppError Create()
            {
                return new RevokeLinkedAppError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RevokeLinkedAppError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "app_not_found":
                        return AppNotFound.Decoder.DecodeFields(reader);
                    case "member_not_found":
                        return MemberNotFound.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Application not found.</para>
        /// </summary>
        public sealed class AppNotFound : RevokeLinkedAppError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AppNotFound> Encoder = new AppNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AppNotFound> Decoder = new AppNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AppNotFound" />
            /// class.</para>
            /// </summary>
            private AppNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AppNotFound</para>
            /// </summary>
            public static readonly AppNotFound Instance = new AppNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AppNotFound" />.</para>
            /// </summary>
            private class AppNotFoundEncoder : enc.StructEncoder<AppNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AppNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AppNotFound" />.</para>
            /// </summary>
            private class AppNotFoundDecoder : enc.StructDecoder<AppNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AppNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AppNotFound Create()
                {
                    return new AppNotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override AppNotFound DecodeFields(enc.IJsonReader reader)
                {
                    return AppNotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Member not found.</para>
        /// </summary>
        public sealed class MemberNotFound : RevokeLinkedAppError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MemberNotFound> Encoder = new MemberNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MemberNotFound> Decoder = new MemberNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MemberNotFound" />
            /// class.</para>
            /// </summary>
            private MemberNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MemberNotFound</para>
            /// </summary>
            public static readonly MemberNotFound Instance = new MemberNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MemberNotFound" />.</para>
            /// </summary>
            private class MemberNotFoundEncoder : enc.StructEncoder<MemberNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MemberNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MemberNotFound" />.</para>
            /// </summary>
            private class MemberNotFoundDecoder : enc.StructDecoder<MemberNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MemberNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MemberNotFound Create()
                {
                    return new MemberNotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override MemberNotFound DecodeFields(enc.IJsonReader reader)
                {
                    return MemberNotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : RevokeLinkedAppError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
