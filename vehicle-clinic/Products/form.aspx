<%@ Page Title="" Language="C#" MasterPageFile="~/layouts/app_layout.Master" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="vehicle_clinic.Products.form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!--content-header-->
        <section class="content-header">
          <div class="container-fluid">
            <div class="row mb-2">
              <div class="col-sm-6">
                <h1>Product</h1>
              </div>
            </div>
          </div>
        </section>
    <!--content-header-->

    <div class="col-md-12">
        <div runat="server" id="formCard">
            <div class="card-header">
                <h3 class="card-title" id="formTitle" runat="server" ></h3>
            </div>
            <form runat="server" id="productForm">
                <div class="card-body">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                              <label for="">Select Product Category <span class="required">*</span></label>
                                <asp:DropDownList ID="categoriesList" runat="server" class="form-control" ValidationGroup="g1">
                                </asp:DropDownList>

                                <asp:requiredfieldvalidator id="role_required" runat="Server" errormessage="Please select any role!" controltovalidate="categoriesList" InitialValue="0" SetFocusOnError="true" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Brand title<span class="required">*</span></label>
                                <asp:TextBox ID="brand_txtbox" placeholder="Enter product brand" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="brand_required" runat="Server" errormessage="Brand of product is required!" controltovalidate="brand_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Product name <span class="required">*</span></label>
                                <asp:TextBox ID="product_name_txtbox" placeholder="Enter product name" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="product_name_required" runat="Server" errormessage="Product name is required!" controltovalidate="product_name_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Price <small>(Pkr) </small><span class="required">*</span></label>
                                <asp:TextBox ID="product_price_txtbox" TextMode="Number" placeholder="Enter product price" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="price_required" runat="Server" errormessage="Product price is required!" controltovalidate="product_price_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-12">
                             <div class="form-group">
                                <label for="">Description</label>
                                <asp:TextBox ID="description_txtbox" TextMode="MultiLine" MaxLength="190" Height="100" placeholder="Enter product description" class="form-control" runat="server"/>
                            </div>
                        </div>
                    </div>
                    
                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Colours <span class="required">*</span></label>
                                <asp:TextBox ID="product_colours_txtbox" placeholder="Enter product colours" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="colours_required" runat="Server" errormessage="Product colours is required!" controltovalidate="product_colours_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Dimensions <span class="required">*</span></label>
                                <asp:TextBox ID="dimensions_txtbox" placeholder="Length x Width" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="dimensions_required" runat="Server" errormessage="Product dimensions is required!" controltovalidate="dimensions_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>

                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Weight <span class="required">*</span></label>
                                <asp:TextBox ID="weight_txtbox" TextMode="Number" placeholder="Enter product weight" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="weight_required" runat="Server" errormessage="Product weight is required!" controltovalidate="weight_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                              <label for="">Select product tax <span class="required">*</span></label>
                                <asp:DropDownList ID="taxlist" runat="server" class="form-control" ValidationGroup="g1">
                                    <asp:ListItem Text="--Select--" Value="0" />
                                    <asp:ListItem Text="10%" Value="1" />
                                    <asp:ListItem Text="25%" Value="2" />
                                    <asp:ListItem Text="30%" Value="3" />
                                </asp:DropDownList>

                                <asp:requiredfieldvalidator id="taxList_required" runat="Server" errormessage="Product Tax should be apply!" controltovalidate="taxlist" InitialValue="0" SetFocusOnError="true" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                              <label for="">Product Discount</label>
                                <asp:DropDownList ID="discountList" runat="server" class="form-control" ValidationGroup="g1">
                                    <asp:ListItem Text="--Select--" Value="0" />
                                    <asp:ListItem Text="10%" Value="1" />
                                    <asp:ListItem Text="25%" Value="2" />
                                    <asp:ListItem Text="50%" Value="3" />
                                    <asp:ListItem Text="70%" Value="4" />
                                    <asp:ListItem Text="75%" Value="5" />
                                    <asp:ListItem Text="80%" Value="6" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Product Release Date <span class="required">*</span></label>
                                <asp:TextBox ID="release_date_txtbox" TextMode="date" placeholder="Enter product release date" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="release_date_required" runat="Server" errormessage="Product must have release date!" controltovalidate="release_date_txtbox" display="Dynamic" forecolor="Red" />
                            </div>
                        </div>

                        <div class="col-md-4">
                             <div class="form-group">
                                <label for="">Approximately delivery days</label>
                                <asp:TextBox ID="delivered_time_txtbox" TextMode="Number" placeholder="product will be delived on..." class="form-control" runat="server"/>
                            </div>
                        </div>
                        
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="">Total solds</label>
                                <asp:TextBox ID="sold_txtbox" TextMode="number" placeholder="Enter..." class="form-control" runat="server"/>                       
                            </div>
                        </div>
                    </div>

                   <div class="row">
                       <div class="col-md-4">
                           <div class="form-group">
                              <label for="">Product Discount</label>
                                <asp:DropDownList ID="manufacture_type_list" runat="server" class="form-control" ValidationGroup="g1">
                                    <asp:ListItem Text="--Select--" Value="0" />
                                    <asp:ListItem Text="Local" Value="Local" />
                                    <asp:ListItem Text="Imported" Value="Imported" />
                                    <asp:ListItem Text="Others" Value="Others" />
                                </asp:DropDownList>
                                 <asp:requiredfieldvalidator id="manufacture_type_required" runat="Server" errormessage="Select manufactured type!" controltovalidate="manufacture_type_list" InitialValue="0" SetFocusOnError="true" display="Dynamic" forecolor="Red" />
                           </div>
                       </div>

                       <div class="col-md-4">
                           <div class="form-group">
                                <label for="">Availible quantity</label>
                                <asp:TextBox ID="availible_qty_txtbox" TextMode="Number" placeholder="Availible quantity" class="form-control" runat="server"/>
                           </div>
                       </div>
                       
                       <div class="col-md-4">
                           <div class="form-group">
                                <label for="">Display order <span class="required">*</span></label>
                                <asp:TextBox ID="display_order_txtbox" TextMode="number" placeholder="Enter product display order" class="form-control" runat="server"/>
                                <asp:requiredfieldvalidator id="display_order_required" runat="Server" errormessage="Please enter product display order!" controltovalidate="display_order_txtbox" display="Dynamic" forecolor="Red" />
                           </div>
                       </div>
                   </div>

                   <div class="form-group">
                      <label for="">Product Images <span class="required">*</span></label> <br/>
                      <asp:FileUpload ID="productImages" runat="server" />
                   </div>

                   <div class="card-footer">
                    <asp:Button ID="submitBtn" OnClick="submitBtn_Click" class="btn btn-primary btn-sm" Text="Save" runat="server" />
                   </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
