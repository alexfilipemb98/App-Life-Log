using Core.Enums;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Life_Log.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace Life_Log.Helpers
{
    /// <summary>
    /// Dialog Helper class
    /// </summary>
    public static class DialogHelper
    {
        #region DIALOGS

        /// <summary>
        /// Show delete dialog
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowDeleteDialog(string caption, string text)
        {
            HtmlTemplate htmlTemplate = GetHtmlTemplate(MessageTypeEnum.Delete);

            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.HtmlImages = GetImageColection();
            args.HtmlTemplate.Assign(htmlTemplate);
            args.Caption = caption;
            args.Text = text;
            args.DefaultButtonIndex = 0;
            args.AllowHtmlText = DefaultBoolean.True;
            args.AllowTrimCaption = true;

            DialogResult result = XtraMessageBox.Show(args);

            return result;
        }

        /// <summary>
        /// Dialog result to show a question dialog
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionDialog(string caption, string text)
        {
            HtmlTemplate htmlTemplate = GetHtmlTemplate(MessageTypeEnum.Question);

            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.HtmlImages = GetImageColection();
            args.HtmlTemplate.Assign(htmlTemplate);
            args.Caption = caption;
            args.Text = text;
            args.DefaultButtonIndex = 0;
            args.ImageOptions.SvgImage = Resources.question_mark;
            args.AllowHtmlText = DefaultBoolean.True;
            args.AllowTrimCaption = true;

            DialogResult result = XtraMessageBox.Show(args);

            return result;
        }

        /// <summary>
        /// Show a notification dialog
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult ShowNotificationDialog(string caption, string text)
        {
            HtmlTemplate htmlTemplate = GetHtmlTemplate(MessageTypeEnum.Notification);

            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.HtmlImages = GetImageColection();
            args.HtmlTemplate.Assign(htmlTemplate);
            args.Caption = caption;
            args.Text = text;
            args.DefaultButtonIndex = 0;
            args.ImageOptions.SvgImage = Resources.question_mark;
            args.AllowHtmlText = DefaultBoolean.True;
            args.AllowTrimCaption = true;

            DialogResult result = XtraMessageBox.Show(args);

            return result;

        }

        #endregion

        #region TOAST

        /// <summary>
        /// Shows a toast message
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="text"></param>
        /// <param name="icon"></param>
        public static void ShowToast(string caption, string text, MessageBoxIcon icon)
        {
            AlertControl alertControl = new AlertControl(AppHelper.MainFormInstance.Container);
            HtmlTemplate htmlTemplate = GetHtmlTemplate(MessageTypeEnum.Toast);
            AlertInfo info = new AlertInfo(caption, text);
            info.Caption = caption;
            info.Text = text;
            // info.ImageOptions.Image = Image;
            //nfo.ImageOptions.SvgImage = SvgImage;s
            info.AutoCloseFormOnClick = false;
            alertControl.AutoFormDelay = 1500;
            alertControl.HtmlTemplate.Template = htmlTemplate.Template;
            alertControl.HtmlTemplate.Styles = htmlTemplate.Styles;
            alertControl.AllowHtmlText = true;

            alertControl.Show(AppHelper.MainFormInstance, info);
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Svg images collection
        /// </summary>
        /// <returns></returns>
        private static SvgImageCollection GetImageColection()
        {
            SvgImageCollection svgImages = new SvgImageCollection
            {
                { "close", Resources.delete },
                { "information", Resources.about }
            };

            return svgImages;
        }

        /// <summary>
        /// Get the html template for the message type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static HtmlTemplate GetHtmlTemplate(MessageTypeEnum type)
        {
            HtmlTemplate htmlTemplate = new HtmlTemplate();

            switch (type)
            {
                case MessageTypeEnum.Toast:
                    htmlTemplate.Template = @"
						<div class=""container"">
							<div class=""popup"">        	
    							<div class=""stripe""></div>
    							<div class=""content"">
    								<div class=""icon-container"">
        								<img class=""icon"" src='${SvgImage}'>
    								</div>
        							<div class=""message"">
            							<div class=""caption"">${Caption}</div>
            							<div class=""text"">${Text}</div>
        							</div>
    								<div id=""closeButton"" class=""close-button"">
        								<img class=""close-icon"" src=""message_close"">
    								</div>
    							</div>
							</div>
						</div>
					";

                    htmlTemplate.Styles = @"
						.container{
							width: 378px;
							height: auto;
							padding: 7px 12px 12px 7px;
						}
						.popup{
							background-color: @Window/0.95;
							border-radius: 6px;
							border-style: solid;
							border-width: 1px 1px 1px 0px;
							box-shadow: 2px 2px 12px @Black/0.2;
							border-color: @Black/0.3;
							display: flex;
							flex-direction: row;
						}
						.content{
							width: 100%;
							display: flex;
							flex-direction: row;
							align-items: center;
							background-color: @Black/0.015;
						}
						.stripe{
							width: 3px;
							background-color: @Black/0.8;
							height: 100%;
							border-radius: 6px 0px 0px 6px;
						}
						.message{
							display: flex;
							flex-direction: column;
							padding: 8px;
							font-family: 'Segoe UI';
							color: @WindowText;
							width: 100%;
						}
						.icon-container{
							padding: 8px;
						}
						.icon{
							width: 22px;
							height: 22px;
						}
						.caption{
							font-size: 11pt;
							font-weight: bold;
							padding: 6px;
						}
						.text{
							font-size: 10.5pt;
							padding: 0px 6px 6px 6px;
						}
						.close-button{
							padding: 8px;
							border-radius: 4px 0px 0px 4px;
							cursor: pointer;
						}
						.close-button:hover{
							background-color: @Black/0.1;
						}
						.close-button:active{
							background-color: @Black/0.2;
						}
						.close-icon{
							width: 22px;
							height: 22px;
						}
					";
                    break;

                case MessageTypeEnum.Delete:
                    htmlTemplate.Template = @"
                        <div class=""frame"" id=""frame"">
	                        <div class=""header"">
		                        <div class=""header-element caption"">${Caption}</div>
		                        <div class=""header-element close-button"" id=""closebutton"">
			                        <img src=""close"" class=""close-button-img"">
		                        </div>
	                        </div>
	                        <div class=""message-text"" id=""content"">${MessageText}</div>
	                        <div class=""buttons"">
		                        <div class=""button"" tabindex=""1"" id=""dialogresult-yes"">DELETE</div>
		                        <div class=""button"" tabindex=""2"" id=""dialogresult-cancel"">CANCEL</div>
	                        </div>
                        </div>
                    ";

                    htmlTemplate.Styles = @"
                       body{
	                        padding: 15px;
	                        font-size: 14px;
	                        font-family: 'Segoe UI';
                        }
                        .frame {
	                        min-width: 470px;
	                        background-color: @Window;
	                        border-radius: 10px;
	                        box-shadow: 0px 8px 16px @Danger/0.6;
                        }
                        .header {
	                        background-color: @Critical;
	                        padding: 5px;
	                        display: flex;
	                        align-items: center;
	                        justify-content: space-between;
	                        border-radius: 8px 8px 0px 0px;
                        }
                        .header-element {
	                        margin: 5px 5px 5px 25px;
                        }
                        .caption {
	                        color: @White;
	                        font-weight: bold;
                        }
                        .close-button-img {
	                        fill: @White;
	                        width: 18px;
	                        height: 18px;
	                        opacity: 0.8;
                        }
                        .close-button {
	                        padding: 5px;
	                        border-radius: 4px;
                        }
                        .close-button:hover {
	                        background-color: @WindowText/0.1;
                        }
                        .close-button:active {
	                        background-color: @ControlText/0.05;
                        }
                        .message-text {
	                        margin: 10px 10px;
	                        font-size: 15px;
	                        color: @WindowText/0.8;
                        }
                        .buttons {
	                        background-color: @Control;
	                        padding: 5px;
	                        display: flex;
	                        align-items: center;
	                        justify-content: space-between;
	                        border-radius: 0px 0px 8px 8px;
                        }
                        .button {
	                        color: @Critical;
	                        border-radius: 5px;
	                        padding: 8px 24px;
	                        margin: 0px 5px;
	                        border: solid 1px @Transparent;
	                        cursor: pointer;
                        }
                        .button:hover {
	                        color: @White;
	                        background-color: @Critical;
	                        box-shadow: 0px 0px 10px @Critical/0.5;
                        }
                        .button:focus {
	                        border-color: @Critical;
                        }
                    ";
                    break;

                case MessageTypeEnum.Question:
                    htmlTemplate.Template = @"
                         <div class=""frame"" id=""frame"">
	                        <div class=""container"">
		                        <div class=""content"">
			                        <img src=""${MessageIcon}"" class=""message icon"">
		                        </div>
		                        <div class=""content"" style=""width:100%"">
		                            <div class=""text caption"">${Caption}</div>
			                        <div id=""content"">
			   	                        <div class=""text message"">${MessageText}</div>
			                        </div>
		                        </div>
	                        </div>
	                        <div class=""buttons"">
		                        <div class=""button"" tabindex=""1"" id=""dialogresult-yes"">Yes</div>
    	                        <div class=""button"" tabindex=""2"" id=""dialogresult-no"">No</div>
                            </div>
                        </div>
                    ";

                    htmlTemplate.Styles = @"
                        body{
							padding: 15px;
							font-size: 10pt;
							font-family: ""Segoe UI"";
							text-align: center;
						}
						.container {
						  display: flex;
						  gap: 20px;
						}
						.frame{
							color: @ControlText;
							background-color: @Window;
							border: 1px solid @Black/0.2;
							border-radius: 10px;
							min-width: 350px;
							box-shadow: 0px 8px 16px @Primary/0.6;
						}
						.icon {
							width: 75px;
							height: 75px;
							opacity: 0.8;
						}
						.content {
							padding: 5px;
							border-radius: 10px;
						}
						.text {
							padding: 10px;
							text-align: left;
						}
						.caption {
							font-size: 15pt;
							font-family: 'Segoe UI Semibold';
							color: @Primary;;
						}
						.message {
							font-size: 15px;
							color: @WindowText/0.8;
						}
						.buttons {
							background-color: @Control;
							padding: 20px;
							display: flex;
							flex-direction: row;
							justify-content: center;
							border-top: 1px solid @Black/0.1;
							border-radius: 0px 0px 8px 8px;
						}
						.button {
							color: @WindowText;
							background-color: @Control;
							min-width: 80px;
							margin: 0px 5px;
							padding: 5px;
							border: 1px solid @Black/0.15;
							border-radius: 5px;
							cursor: pointer;
						}
						.button:hover {
							background-color: @Black/0.1;
						}
						.button:focus {
							background-color: @HighlightAlternate;
							border: 1px solid @HighlightAlternate;
						}
                    ";
                    break;

                case MessageTypeEnum.Notification:
                    htmlTemplate.Template = @"
						<div class=""frame"" id=""frame"">
							<div class=""header"">
								<div class=""caption"">${Caption}</div>
    							<div class=""close-button"" id=""closebutton"">
									<img src=""close"" class=""close-button-img"" id=""close"">
								</div>
							</div>
							<div class=""content"" id=""content"">
    							<img src=""information"" class=""message icon"">
    							<div class=""message text"">${MessageText}</div>
    							<div class=""message button"" tabindex=""1"" id=""dialogresult-ok"">OK</div>
							</div>
						</div>
					";

                    htmlTemplate.Styles = @"
						body{	
							padding: 20px;
							font-size: 14px;
							font-family: 'Segoe UI';
						}
						.frame {
							width: 450px;
							color: @ControlText;
							background-color: @Window;
							border: 1px solid @Primary;
							border-radius: 16px;
							display: flex;
							flex-direction: column;
							justify-content: center;
							box-shadow: 0px 8px 16px @Primary/0.6;
						}
						.header {
							padding: 8px;
							color: @White;
							background-color: @Primary;
							border-radius: 15px 15px 0px 0px;
							display: flex;
							justify-content: space-between;
							align-items: center;
						}
						.caption {
							margin: 0px 10px;
							font-weight: bold;
						}
						.close-button {
							padding: 8px;
							border-radius: 5px;
						}
						.close-button:hover {
							background-color: @WindowText/0.1;
						}
						.close-button:active {
							background-color: @ControlText/0.05;
						}
						.close-button-img {
							fill: White;
							width: 18px;
							height: 18px;
							opacity: 0.8;
						}
						.content {
							display: flex;
							align-items: center;
							flex-direction: column;
							padding: 10px;
						}
						.message {
							margin: 7px;
						}
						.icon {
							width: 48px;
							height: 48px;
							opacity: 0.8;
						}
						.text {
							color: @ControlText;
							text-align: center;
						}
						.button {
							color: @Primary;
							padding: 8px 24px;
							border: 1px solid @Primary;
							border-radius: 5px;
						}
						.button:hover {
							color: @White;
							background-color: @Primary;
							box-shadow: 0px 0px 10px @Primary/0.5;
						}
					";
                    break;
            }

            return htmlTemplate;
        }

        #endregion
    }
}
