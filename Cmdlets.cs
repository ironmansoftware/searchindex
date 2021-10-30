using System.Collections;
using System.Management.Automation;
using Microsoft.Search.Interop;

namespace searchindex
{
    [Cmdlet(VerbsCommon.Get, "SearchIndexStatus")]
    public class GetSearchIndexStatusCommand : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            CSearchManager manager = new CSearchManager();

            // SystemIndex catalog is the default catalog in Windows
            ISearchCatalogManager catalogManager = manager.GetCatalog("SystemIndex");

            catalogManager.GetCatalogStatus(out _CatalogStatus status, out _CatalogPausedReason reason);

            var numberOfItems = catalogManager.NumberOfItems();
            var urlBeingIndex = catalogManager.URLBeingIndexed();

            WriteObject(new Hashtable()
            {
                { "Status", status },
                { "Reason", reason },
                { "NumberOfItems", numberOfItems },
                { "URLBeingIndexed", urlBeingIndex }
            });
        }
    }


}

