using System.Linq;
using LinkSampleAddIn;
using Soneta.Business;
using Soneta.Core.DbTuples;

[assembly: Worker(typeof(LinkCreatorWorker), typeof(DbTuple))]

namespace LinkSampleAddIn
{

    internal class LinkCreatorWorker
    {

        [Context]
        public DbTuple Tuple { get; set; }

        [Action("Utwórz link i wyślij",
            Target = ActionTarget.Menu | ActionTarget.ToolbarWithText,
            Icon = ActionIcon.Envelope,
            Mode = ActionMode.SingleSession
        )]
        public void CreateAndSend()
        {
        }

        public static bool IsVisibleCreateAndSend
            (DbTuple tuple) => tuple?.Definicja
                                   .Fields.Any(field => field.Name == "TrescEmail") ?? false;

    }

}
