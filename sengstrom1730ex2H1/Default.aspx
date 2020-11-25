<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sengstrom1730ex2H._Default" %>

<script runat="server">

    protected void DateCalculationButton_Click(object sender, EventArgs e)
    {
        {
          TextBox1aResult.Text = DateTime.Now.ToShortDateString();
            TextBox1bResult.Text = DateTime.Now.ToShortTimeString();
            TextBox2aResult.Text = DateTime.Today.ToShortDateString();
            TextBox2bResult.Text = DateTime.Today.ToShortTimeString();
            TextBox3aResult.Text = DateTime.Today.Year.ToString();
            TextBox3bResult.Text = DateTime.Today.Month.ToString();
            TextBox3cResult.Text = DateTime.Today.Day.ToString();
            TextBox4Result.Text = DateTime.Today.AddDays(90).ToShortDateString();
            TextBox5Result.Text = DateTime.Today.AddMonths(3).ToShortDateString();
            TextBox6Result.Text = Ex2hCalculations.DateCalc06(TextBox6a.Text, TextBox6b.Text, TextBox6c.Text);
            TextBox7Result.Text = Ex2hCalculations.DateCalc07(TextBox7.Text);
            TextBox8Result.Text = Ex2hCalculations.DateCalc08(TextBox8.Text);
            TextBox9Result.Text = Ex2hCalculations.DateCalc09(TextBox9a.Text, TextBox9b.Text);
            TextBox10Result.Text = Ex2hCalculations.DateCalc10(TextBox10a.Text, TextBox10b.Text); 
        }

    }
</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">
        <div class="col-md-4">
            <h2>DateTime Methods</h2>  
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="1) DateTime.Now: "></asp:Label>
                <asp:TextBox ID="TextBox1aResult" runat="server" Enabled="False" Width="82px"></asp:TextBox>
                <asp:TextBox ID="TextBox1bResult" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="2) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox2aResult" runat="server" Enabled="False" Width="80px"></asp:TextBox>
                <asp:TextBox ID="TextBox2bResult" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="3) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox3aResult" runat="server" Enabled="False" Width="40px"></asp:TextBox>
                <asp:TextBox ID="TextBox3bResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox3cResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="4) DateTime.AddDays(30): "></asp:Label>
                <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False" Width="80px"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="5) DateTime.AddMonths(3): "></asp:Label>
                <asp:TextBox ID="TextBox5Result" runat="server" Width="80" Enabled="False"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="6) Date Time (y, m, d): "></asp:Label>
                <asp:TextBox ID="TextBox6a" runat="server" Width="40px">2019</asp:TextBox>
                <asp:TextBox ID="TextBox6b" runat="server" Width="30px">11</asp:TextBox>
                <asp:TextBox ID="TextBox6c" runat="server" Width="30px">01</asp:TextBox>
                <asp:TextBox ID="TextBox6Result" runat="server" Enabled="False" Width="90px"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="7) DateTime.Parse(): "></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" Width="125px">November 1, 2019</asp:TextBox>
                <asp:TextBox ID="TextBox7Result" runat="server" Width="80" Enabled="False"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="8) DateTime.TryParse(): "></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" Width="125px">November 1, 2019</asp:TextBox>
                <asp:TextBox ID="TextBox8Result" runat="server" Enabled="False" Width="80px"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="9) DateA - DateB: "></asp:Label>
                <asp:TextBox ID="TextBox9a" runat="server" Width="80px">1/13/2013</asp:TextBox>
                <asp:TextBox ID="TextBox9b" runat="server" Width="80px">12/12/2012</asp:TextBox>
                <asp:TextBox ID="TextBox9Result" runat="server" Enabled="False" Width="80px"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="10) DateA &gt; DateB: "></asp:Label>
                <asp:TextBox ID="TextBox10a" runat="server" Width="80px">1/13/2013</asp:TextBox>
                <asp:TextBox ID="TextBox10b" runat="server" Width="80px">12/12/2012</asp:TextBox>
                <asp:TextBox ID="TextBox10Result" runat="server" Enabled="False" Width="110px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="DateCalculationButton" runat="server" Text="Date Calculations" OnClick="DateCalculationButton_Click" />
            </div>
        </div>


        <div class="col-md-4">
            <h2>String Methods</h2>   
             <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="   1) Remove/Insert: "></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server">late</asp:TextBox>
                <asp:TextBox ID="TextBox11Result" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
             <div class="form-group">
                &nbsp;
                 <asp:Label ID="Label13" runat="server" Text="2) Remove/Insert: "></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server">cater</asp:TextBox>
                <asp:TextBox ID="TextBox12Result" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
             <div class="form-group">
                &nbsp;<asp:Label ID="Label14" runat="server" Text="3) Substring/ToUpper: "></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server">ABBlue22</asp:TextBox>
                <asp:TextBox ID="TextBox13Result" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
             <div class="form-group">
                 <asp:Label ID="Label15" runat="server" Text="4) PadLeft: "></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server">123.45</asp:TextBox>
                <asp:TextBox ID="TextBox14Result" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
             <div class="form-group">
                &nbsp;<asp:Label ID="Label16" runat="server" Text="5) Replace:"></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server" Width="103px">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox15Result" runat="server" Enabled="False" Width="135px"></asp:TextBox>
            </div>
             <div class="form-group">
                &nbsp;<asp:Label ID="Label17" runat="server" Text="6) Replace/Length/Insert:"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox16Result" runat="server" Enabled="False" Width="126px"></asp:TextBox>
            </div>
             <div class="form-group">
                 <asp:Label ID="Label18" runat="server" Text="7) ToLower/Containes: "></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server">308 Pioneer Rd</asp:TextBox>
                <asp:TextBox ID="TextBox17Result" runat="server" Enabled="False" Width="75px"></asp:TextBox>
            </div>
             <div class="form-group">
                &nbsp;<asp:Label ID="Label19" runat="server" Text="8) IndexOf/Substring:"></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server" Width="165px">1250 Homer Rd, Winona</asp:TextBox>
                <asp:TextBox ID="TextBox18Result" runat="server" Enabled="False" Width="91px"></asp:TextBox>
            </div>
             <div class="form-group">
                &nbsp;<asp:Label ID="Label20" runat="server" Text="9) LastIndexof/Substring:"></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server" Width="211px">111 1st St, Lake City, MN 55041</asp:TextBox>
                <asp:TextBox ID="TextBox19Result" runat="server" Enabled="False" Width="87px"></asp:TextBox>
            </div>
             <div class="form-group">
                &nbsp;<asp:Label ID="Label21" runat="server" Text="10) StringBuilder.Append:"></asp:Label>
                 <asp:Label ID="Label20Result" runat="server" Text="[Label20Result]"></asp:Label>
            </div>
            <div class="form-group">
                
                <asp:Button ID="stringButton" runat="server" Text="String Calculations" OnClick="stringButton_Click"  />
                
        </div>        
    </div>

    </div>
</asp:Content>