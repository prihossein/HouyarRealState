/**
 * @license Copyright (c) 2003-2018, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function (config) {
	config.contentsLangDirection = 'rtl';
	config.language = 'fa';
	config.height = 400;

	// Define changes to default configuration here:
	config.contentsCss = '/plugins/ckeditor/customfonts/fonts.css';
	///plugins/ckeditor/customfonts/fonts.css
	///plugins/ckeditor/contents.css
	//the next line add the new font to the combobox in CKEditor
	//config.font_names = '<Cutsom Font Name>/<YourFontName>;' + config.font_names;
	config.font_names = 'لوتوس/Lotus;' + config.font_names;
	config.font_names = 'میترا/Mitra;' + config.font_names;
	config.font_names = 'یکان/BYekan;' + config.font_names;
	config.font_names = 'نازنین/BNazanin;' + config.font_names;
	config.font_names = 'ساحل/Sahel;' + config.font_names;
	config.font_names = 'صمیم/Samim;' + config.font_names;
	config.font_names = 'وزیر/BVazir;' + config.font_names;
	config.font_names = 'پرستو/Parastoo;' + config.font_names;
	config.font_names = 'تنها/Tanha;' + config.font_names;
	config.font_names = 'IRANSans/IRANSans;' + config.font_names;
	config.font_names = 'Tahoma/Tahoma;' + config.font_names;
	config.font_names = 'Arial/Arial;' + config.font_names;
	config.font_names = 'Comic Sans MS/Comic Sans MS, cursive;' + config.font_names;
	config.font_names = 'Courier New/Courier New,Courier,monospace;' + config.font_names;
	config.font_names = 'Georgia/Georgia,serif;' + config.font_names;
	config.font_names = 'Lucida Sans Unicode/Lucida Sans Unicode,Lucida Grande,sans-serif;' + config.font_names;
	config.font_names = 'Times New Roman/Times New Roman,Times,serif;' + config.font_names;
	config.font_names = 'Trebuchet MS/Trebuchet MS,Helvetica,sans-serif;' + config.font_names;
	config.font_names = 'Verdana/Verdana,Geneva,sans-serif;' + config.font_names;
	//config.extraPlugins = 'colorbutton,font,justify,bidi';


	config.removeDialogTabs = 'image:advanced;image:Link;link:advanced;link:upload';
	config.filebrowserImageUploadUrl = '/Home/UploadImage';//Action for Uploding image  
	// %REMOVE_START%
	// The configuration options below are needed when running CKEditor from source files.
	//config.plugins = 'dialogui,dialog,about,a11yhelp,basicstyles,blockquote,notification,button,toolbar,clipboard,panel,floatpanel,menu,contextmenu,resize,elementspath,enterkey,entities,popup,filetools,filebrowser,floatingspace,listblock,richcombo,format,horizontalrule,htmlwriter,wysiwygarea,image,indent,indentlist,fakeobjects,link,list,magicline,maximize,pastetext,pastefromword,removeformat,showborders,sourcearea,specialchar,menubutton,scayt,stylescombo,tab,table,tabletools,tableselection,undo,lineutils,widgetselection,widget,notificationaggregator,uploadwidget,uploadimage,wsc,colordialog,panelbutton,colorbutton,justify,bidi,font';
	config.plugins = 'dialogui,dialog,basicstyles,blockquote,notification,button,toolbar,panel,floatpanel,menu,contextmenu,resize,elementspath,enterkey,entities,popup,filetools,filebrowser,floatingspace,listblock,richcombo,format,horizontalrule,htmlwriter,wysiwygarea,image,indent,indentlist,fakeobjects,link,list,magicline,maximize,showborders,sourcearea,specialchar,menubutton,table,tabletools,tableselection,undo,lineutils,widgetselection,widget,notificationaggregator,uploadwidget,uploadimage,wsc,colordialog,panelbutton,colorbutton,justify,bidi,font';
	config.skin = 'moono-lisa';
	// %REMOVE_END%
	config.allowedContent = {
		script: true,
		$1: {
			// This will set the default set of elements
			elements: CKEDITOR.dtd,
			attributes: true,
			styles: true,
			classes: true
		}
	};
	// Define changes to default configuration here.
	// For complete reference see:
	// http://docs.ckeditor.com/#!/api/CKEDITOR.config

	// The toolbar groups arrangement, optimized for two toolbar rows.
	config.toolbarGroups = [
		{ name: 'clipboard', groups: ['undo'] },
		{ name: 'links' },
		{ name: 'insert' },
		{ name: 'forms' },
		{ name: 'tools' },
		{ name: 'document', groups: ['mode', 'document', 'doctools'] },
		{ name: 'others' },
		'/',
		{ name: 'basicstyles', groups: ['basicstyles', 'cleanup'] },
		{ name: 'paragraph', groups: ['list', 'indent', 'blocks', 'align', 'bidi'] },
		{ name: 'styles' },
		{ name: 'colors' }
	];

	// Remove some buttons provided by the standard plugins, which are
	// not needed in the Standard(s) toolbar.
	config.removeButtons = 'Underline,Subscript,Superscript';

	// Set the most common block elements.
	config.format_tags = 'p;h1;h2;h3;h4;h5;h6;pre';

	// Simplify the dialog windows.
	config.removeDialogTabs = 'image:advanced;link:advanced';	
};

