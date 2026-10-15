namespace HouyarRealState.Application.Wrappers
{
    public class TextStatistics
    {
        public int CharacterCount { get; set; }
        public int WordCount { get; set; }

        public int InternalLinkCount { get; set; }
        public int ExternalLinkCount { get; set; }

        public int ImageCount { get; set; }
        public int ImagesWithKeywordInAltCount { get; set; }
        public int KeywordInImageAltCount { get; set; }

        public int UnorderedListCount { get; set; }
        public int TableCount { get; set; }

        public int H1Count { get; set; }
        public int H2Count { get; set; }
        public int H3Count { get; set; }
        public int H4Count { get; set; }
        public int H5Count { get; set; }
        public int H6Count { get; set; }

        public int KeywordInHeadingsCount { get; set; }
        public int HeadingsWithKeywordCount { get; set; }

        public int KeywordInTextCount { get; set; }

        public int SeoTitleCharacterCount { get; set; }
        public int MetaDescriptionCharacterCount { get; set; }
    }
}
