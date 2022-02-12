<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/frontend_layout.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="vehicle_clinic.Frontend.products.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-md-1"></div>
    <div class="col-md-10">
         <form runat="server" id="userForm">
                <div class="card-body">

                    <div runat="server" id="errorMessage" class="errClass"></div>

                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="">First Name <span class="required">*</span></label>
                                <asp:TextBox ID="first_name_txtbox" placeholder="Enter first name" ReadOnly="true" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="first_name_required" runat="Server" errormessage="First name is required!" controltovalidate="first_name_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group"> 
                                <label for="">Second Name <span class="required">*</span></label>
                                <asp:TextBox ID="second_name_txtbox" placeholder="Enter second name" ReadOnly="true" class="form-control" runat="server" />
                                <asp:requiredfieldvalidator id="last_name_required" runat="Server" errormessage="Last name is required!" controltovalidate="second_name_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-6">
                             <div class="form-group">
                            <label for="">Select Country <span class="required">*</span></label>
                            <asp:DropDownList ID="countryList" runat="server" class="form-control" ValidationGroup="g1">
                                <asp:ListItem Text="--Select--" Value="none" />
                                <asp:ListItem Text="America" Value="America" />
                                <asp:ListItem Text="China" Value="China" />
                                <asp:ListItem Text="Japan" Value="Japan" />
                                <asp:ListItem Text="Paksitan" Value="Paksitan" />
                                <asp:ListItem Text="India" Value="India" />
                                <asp:ListItem Text="Italy" Value="Italy" />
                            </asp:DropDownList>
                            <asp:requiredfieldvalidator id="brand_required" runat="Server" errormessage="Please select any country!" controltovalidate="countryList" InitialValue="0" SetFocusOnError="true" display="Dynamic" forecolor="Red" />
                        </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group"> 
                                <label for="">Full Address <span class="required">*</span></label>
                                <asp:TextBox ID="addressTxtbox" placeholder="Enter full address" class="form-control" runat="server" />
                                <asp:requiredfieldvalidator id="address_requied" runat="Server" errormessage="Address must be required!" controltovalidate="addressTxtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group"> 
                                <label for="">Email <span class="required">*</span></label>
                                <asp:TextBox ID="email_txtbox" ReadOnly="true" placeholder="Enter full address" class="form-control" runat="server" />
                                <asp:requiredfieldvalidator id="email_requried" runat="Server" errormessage="Email field is required!" controltovalidate="email_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                        <div class="col-md-6">
                             <div class="form-group"> 
                                <label for="">Contact <span class="required">*</span></label>
                                <asp:TextBox ID="contact_txbox" TextMode="Number" placeholder="Enter phone number" class="form-control" runat="server" />
                                <asp:requiredfieldvalidator id="contact_required" runat="Server" errormessage="Contact No. must be required!" controltovalidate="contact_txbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-12">
                             <div class="form-group">
                                <label for="orderNote_txtbox">Order Note</label>
                                <asp:TextBox ID="orderNote_txtbox" TextMode="MultiLine" MaxLength="190" Height="100" placeholder="Enter description" class="form-control" runat="server"/>
                            </div>
                        </div>
                    </div>

                    <p class="text-danger"><b>Please read all details before submit!</b></p>

                    <div class="row">
                        <div class="col-md-2"></div>
                        <div class="col-md-4">
                            <asp:Button ID="submitBtn" OnClick="submitBtn_Click" class="btn btn-success btn-sm btn-block" Text="Purchase" runat="server" />
                        </div>
                        <div class="col-md-4">
                            <asp:Button ID="discardBtn" OnClick="discardBtn_Click" class="btn btn-danger btn-sm btn-block" Text="Discard" runat="server" />
                        </div>
                        <div class="col-md-2"></div>
                    </div>
                    

                    <br><br>
                </div>
            </form>
    </div>
    <div class="col-md-1"></div>


</asp:Content>
