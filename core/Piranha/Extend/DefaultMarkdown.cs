/*
 * Copyright (c) 2017-2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

using Markdig;

namespace Piranha.Extend
{
    /// <summary>
    /// Interface for converting markdown to Html.
    /// </summary>
    public class DefaultMarkdown : IMarkdown
    {
        /// <summary>
        /// Transforms the given markdown string to html.
        /// </summary>
        /// <param name="md">The markdown</param>
        /// <returns>The transformed html</returns>
        public string Transform(string md)
        {
            if (!string.IsNullOrEmpty(md))
            {
                return Markdown.ToHtml(md);
            }
            return md;
        }
    }
}
