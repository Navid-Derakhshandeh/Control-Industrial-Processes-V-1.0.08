#pragma checksum "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29d51f505c6a6d6621a4e21247e9f704a6677fb"
// <auto-generated/>
#pragma warning disable 1591
namespace Control_Industrial_Processes_Blazor_Version.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Control_Industrial_Processes_Blazor_Version;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Control_Industrial_Processes_Blazor_Version.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\_Imports.razor"
using Control_Industrial_Processes_Blazor_Version.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
using uPLibrary.Networking.M2Mqtt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
using uPLibrary.Networking.M2Mqtt.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Coolingfan")]
    public partial class Coolingfan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-xjpyto32f3>Cooling fan</h1>\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3 b-xjpyto32f3>Control Industrial Processes Blazor Version</h3>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
                                          Connect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "b-xjpyto32f3");
            __builder.AddContent(6, "Connect");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
                                          Receive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "b-xjpyto32f3");
            __builder.AddContent(12, "Receive");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
                                          Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-xjpyto32f3");
            __builder.AddContent(18, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\nVoltage\r\n");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
              messageToSend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageToSend = __value, messageToSend));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(23, "b-xjpyto32f3");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "b-xjpyto32f3");
            __builder.AddContent(27, "RPM: ");
            __builder.AddContent(28, 
#nullable restore
#line 21 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
         receivedMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.AddMarkupContent(30, @"<div class=""fan-container"" b-xjpyto32f3><div class=""fan"" b-xjpyto32f3><div class=""fan-blade"" b-xjpyto32f3></div>
        <div class=""fan-blade"" b-xjpyto32f3></div>
        <div class=""fan-blade"" b-xjpyto32f3></div>
        <div class=""fan-blade"" b-xjpyto32f3></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\test5\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Control Industrial Processes Blazor Version\Pages\Coolingfan.razor"
        private MqttClient _client;
    private string _brokerAddress = "localhost";
    private string username = "test_user"; // Change to your username
    private string password = "test_password"; // Change to your password
    private string topicReceive = "unit1/tag3";
    private string topicSend = "unit1/tag4";
    private string receivedMessage = "Waiting for data...";
    private string messageToSend = "";
    private string fanSpeed = "2s"; // Default fan speed

    public void Connect()
    {
        try
        {
            _client = new MqttClient(_brokerAddress);
            _client.MqttMsgPublishReceived += MessageReceived;
            _client.Connect("client_id_1", "test", "test@unit1");
            Console.WriteLine("Connected to MQTT broker.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Connection failed: {ex.Message}");
        }
    }

    public void Send()
    {
        if (_client != null && _client.IsConnected)
        {
            var payload = Encoding.UTF8.GetBytes(messageToSend);
            _client.Publish(topicSend, payload, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
            Console.WriteLine($"Published message to {topicSend}: {messageToSend}");
        }
        else
        {
            Console.WriteLine("MQTT client is not connected.");
        }
    }

    public void Receive()
    {
        if (_client != null && _client.IsConnected)
        {
            _client.Subscribe(new string[] { topicReceive }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            Console.WriteLine($"Subscribed to {topicReceive}");
        }
        else
        {
            Console.WriteLine("MQTT client is not connected.");
        }
    }

    private void MessageReceived(object sender, MqttMsgPublishEventArgs e)
    {
        receivedMessage = Encoding.UTF8.GetString(e.Message);
        InvokeAsync(StateHasChanged); // Ensure UI updates
        Console.WriteLine($"Received message from {topicReceive}: {receivedMessage}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
