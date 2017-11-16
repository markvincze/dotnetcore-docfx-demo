using System;
using System.Text;

namespace DotnetCoreDocfxDemo
{
    /// <summary>
    /// This is a dummy type to illustrate how the API Reference is generated.
    /// </summary>
    /// <remarks>
    /// The comments over this type include some remarks.
    /// Ego vero volo in virtute vim esse quam maximam. Respondeat totidem verbis. Duo Reges: constructio interrete.
    /// Hoc sic expositum dissimile est superiori. Hanc ergo intuens debet institutum illud quasi signum absolvere.
    /// </remarks>
    public class DemoClass
    {
        /// <summary>
        /// This is a property for demo purposes.
        /// </summary>
        /// <returns>It returns a hardcoded value, "Foo".</returns>
        public string DemoProperty { get; set; }

        /// <summary>
        /// The default constructor, it sets the value of the <cref="DemoProperty" /> property.
        /// </summary>
        public DemoClass()
        {
            DemoProperty = "Foo";
        }

        /// <summary>
        /// A method for demo purposes.
        /// </summary>
        /// <param name="count">Specifies the number of times we'd like to repeat the value.</param>
        /// <returns>The value of <cref="DemoProperty" /> repeated <paramref="count" /> times.</returns>
        public string DemoMethod(int count)
        {
            var sb = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                sb.Append(DemoProperty);
            }

            return sb.ToString();
        }
    }
}