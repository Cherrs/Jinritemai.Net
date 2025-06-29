using System.Collections.Generic;

public class InvoiceDetailExtra
{
    public string gov_subsidy_uninvoice_amount { get; set; }
    public string post_amount { get; set; }
    public string recycle_credit_deduction_amount { get; set; }
}

public class InvoiceFileList
{
    public string file_name { get; set; }
    public string tos_url { get; set; }
}

public class InvoiceList
{
    public long apply_scene { get; set; }
    public long apply_time { get; set; }
    public string bank_name { get; set; }
    public string bank_no { get; set; }
    public string company_address { get; set; }
    public string company_mobile { get; set; }
    public string end_reason { get; set; }
    public string end_time { get; set; }
    public string file_name { get; set; }
    public string invoice_amount { get; set; }
    public string invoice_detail { get; set; }
    public InvoiceDetailExtra invoice_detail_extra { get; set; }
    public List<InvoiceFileList> invoice_file_list { get; set; }
    public string invoice_status { get; set; }
    public string invoice_status_type { get; set; }
    public string invoice_type { get; set; }
    public string latest_upload_time { get; set; }
    public string order_status { get; set; }
    public string registation_id { get; set; }
    public string shop_id { get; set; }
    public string shop_order_id { get; set; }
    public string tax_no { get; set; }
    public string title { get; set; }
    public string title_type { get; set; }
    public string tos_url { get; set; }
    public string upload_time { get; set; }
}

public class InvoiceListResponse
{
    public List<InvoiceList> invoice_list { get; set; }
    public string total { get; set; }
}

