window.hitos=[];function hito(nombre){window.hitos.push([nombre,new Date().getTime()]);}hito("C Common.js");if(mw.config.get('wgArticleId')===0&&mw.config.get('wgNamespaceNumber')==2){var titleParts=mw.config.get('wgPageName').split('/');if(titleParts.length==2){var userSkinPage=titleParts.shift()+'/'+mw.config.get('skin');if(titleParts.slice(-1)=='skin.js'){window.location.href=mw.util.wikiGetlink(userSkinPage+'.js');}else if(titleParts.slice(-1)=='skin.css'){window.location.href=mw.util.wikiGetlink(userSkinPage+'.css');}}}window.addPortletLink=function(){return mw.util.addPortletLink.apply(mw.util,arguments);};function getURLParamValue(paramName,url){return mw.util.getParamValue(paramName,url);}var extraCSS=mw.util.getParamValue("withCSS");if(extraCSS&&extraCSS.match(/^MediaWiki:[^&<>=%]*\.css$/)){importStylesheet(extraCSS);}var extraJS=mw.util.getParamValue("withJS");if(extraJS&&extraJS.match(/^MediaWiki:[^&<>=%]*\.js$/)){importScript(extraJS);}var hasClass=(function(){var reCache={
};return function(element,className){return(reCache[className]?reCache[className]:(reCache[className]=new RegExp("(?:\\s|^)"+className+"(?:\\s|$)"))).test(element.className);};})();if(navigator.appName=='Microsoft Internet Explorer'){var oldWidth;var docEl=document.documentElement;var fixIEScroll=function(){if(!oldWidth||docEl.clientWidth>oldWidth){doFixIEScroll();}else{setTimeout(doFixIEScroll,1);}oldWidth=docEl.clientWidth;};var doFixIEScroll=function(){docEl.style.overflowX=(docEl.scrollWidth-docEl.clientWidth<4)?"hidden":"";};document.attachEvent("onreadystatechange",fixIEScroll);document.attachEvent("onresize",fixIEScroll);mw.util.addCSS('@media print { sup, sub, p, .documentDescription { line-height: normal; }}');mw.util.addCSS('div.overflowbugx { overflow-x: scroll !important; overflow-y: hidden !important; } div.overflowbugy { overflow-y: scroll !important; overflow-x: hidden !important; }');mw.util.addCSS('.iezoomfix div, .iezoomfix table { zoom: 1;}');}$(function(){if(
document.location.search.indexOf("undo=")!=-1&&document.getElementsByName('wpAutoSummary')[0]){document.getElementsByName('wpAutoSummary')[0].value='';}});$(function(){if(mw.config.get('wgCanonicalNamespace')=="Special"&&mw.config.get('wgCanonicalNamespace')=="Search")importScript('MediaWiki:SpecialSearch.js');});$(function(){hito("C cerrar mensajes");if(document.getElementById("cierraPadre")){document.getElementById("cierraPadre").childNodes[0].onclick=function(){document.getElementById("cierraPadre").style.cursor='pointer';document.getElementById("cierraPadre").parentNode.style.display='none';return false;}}hito("F cerrar mensajes");});if($.inArray('sysop',wgUserGroups)>-1){importStylesheet('MediaWiki:Sysop.css');if(!window.disableSysopJS){$(function(){importScript('MediaWiki:Sysop.js');});}}mw.loader.load('//meta.wikimedia.org/w/index.php?title=MediaWiki:Wikiminiatlas.js&action=raw&ctype=text/javascript&smaxage=21600&maxage=86400');var osm_proj_map='mapa';var osm_proj_lang='es';
importScriptURI('//meta.wikimedia.org/w/index.php?title=MediaWiki:OSM.js&action=raw&ctype=text/javascript&smaxage=21600&maxage=86400');importScript('MediaWiki:Wikimediaplayer.js');if(mw.config.get('wgPageName')=='Wikipedia:Portada'||mw.config.get('wgPageName')=='Wikipedia Discusión:Portada'){$(function(){hito("C mainPageAppendCompleteListLink");mw.util.addPortletLink('p-lang','http://es.wikipedia.org/wiki/Anexo:Wikipedias','Lista completa','interwiki-completelist','Lista completa de Wikipedias');hito("F mainPageAppendCompleteListLink");});}function ts_resortTable(lnk){var span=lnk.getElementsByTagName('span')[0];var td=lnk.parentNode;var tr=td.parentNode;var column=td.cellIndex;var table=tr.parentNode;while(table&&!(table.tagName&&table.tagName.toLowerCase()=='table'))table=table.parentNode;if(!table)return;if(table.rows.length<=1)return;if(ts_number_transform_table==null){ts_initTransformTable();}var rowStart=(table.tHead&&table.tHead.rows.length>0?0:1);var itm="";for(var i=rowStart;
i<table.rows.length;i++){if(table.rows[i].cells.length>column){itm=ts_getInnerText(table.rows[i].cells[column]);itm=itm.replace(/^[\s\xa0]+/,"").replace(/[\s\xa0]+$/,"");if(itm!="")break;}}var sortfn=ts_sort_generic;var preprocessor=ts_toLowerCase;if(/\d\d? de [a-zA-Z]+ de \d+$/.test(itm)){preprocessor=ts_dateToSortKey;}else if(/^\d\d[\/.-]\d\d[\/.-]\d\d\d\d$/.test(itm)){preprocessor=ts_dateToSortKey;}else if(/^\d\d[\/.-]\d\d[\/.-]\d\d$/.test(itm)){preprocessor=ts_dateToSortKey;}else if(/(^[\u00a3$\u20ac\u00a4\u00a5]|\u00a2$)/.test(itm)){preprocessor=ts_currencyToSortKey;}else if(ts_number_regex.test(itm)){preprocessor=ts_parseFloat;}var reverse=(span.getAttribute("sortdir")=='down');var newRows=new Array();var staticRows=new Array();for(var j=rowStart;j<table.rows.length;j++){var row=table.rows[j];if((" "+row.className+" ").indexOf(" unsortable ")<0){var keyText=ts_getInnerText(row.cells[column]);var oldIndex=(reverse?-j:j);var preprocessed=preprocessor(keyText);newRows[newRows.length
]=new Array(row,preprocessed,oldIndex);}else staticRows[staticRows.length]=new Array(row,false,j-rowStart);}newRows.sort(sortfn);var arrowHTML;if(reverse){arrowHTML='<img src="'+ts_image_path+ts_image_down+'" alt="&darr;"/>';newRows.reverse();span.setAttribute('sortdir','up');}else{arrowHTML='<img src="'+ts_image_path+ts_image_up+'" alt="&uarr;"/>';span.setAttribute('sortdir','down');}for(var i=0;i<staticRows.length;i++){var row=staticRows[i];newRows.splice(row[2],0,row);}for(var i=0;i<newRows.length;i++){if((" "+newRows[i][0].className+" ").indexOf(" sortbottom ")==-1)table.tBodies[0].appendChild(newRows[i][0]);}for(var i=0;i<newRows.length;i++){if((" "+newRows[i][0].className+" ").indexOf(" sortbottom ")!=-1)table.tBodies[0].appendChild(newRows[i][0]);}var spans=getElementsByClassName(tr,"span","sortarrow");for(var i=0;i<spans.length;i++){spans[i].innerHTML='<img src="'+ts_image_path+ts_image_none+'" alt="&darr;"/>';}span.innerHTML=arrowHTML;if(ts_alternate_row_colors){ts_alternate(
table);}}function ts_dateToSortKey(date){if(date.length>14){date=date.toLowerCase();if(date.charAt(1)==" "||date.charAt(1)=="-"){var dia='0'+date.charAt(0);}else{var dia=date.substr(0,2);}var iniciomes=date.indexOf(" de ")+4;var finmes=date.lastIndexOf(" de ");var longmes=finmes-iniciomes;switch(date.substr(iniciomes,longmes)){case"enero":var mes="01";break;case"febrero":var mes="02";break;case"marzo":var mes="03";break;case"abril":var mes="04";break;case"mayo":var mes="05";break;case"junio":var mes="06";break;case"julio":var mes="07";break;case"agosto":var mes="08";break;case"septiembre":var mes="09";break;case"octubre":var mes="10";break;case"noviembre":var mes="11";break;case"diciembre":var mes="12";break;}for(var anno=date.substr(finmes+4);anno.length<4;anno='0'+anno);return anno+mes+dia;}else if(date.length==10){if(ts_europeandate==false){return date.substr(6,4)+date.substr(0,2)+date.substr(3,2);}else{return date.substr(6,4)+date.substr(3,2)+date.substr(0,2);}}else if(date.length
==8){yr=date.substr(6,2);if(parseInt(yr)<50){yr='20'+yr;}else{yr='19'+yr;}if(ts_europeandate==true){return yr+date.substr(3,2)+date.substr(0,2);}else{return yr+date.substr(0,2)+date.substr(3,2);}}return"00000000";}function ts_parseFloat(num){if(!num)return 0;num=num.replace(/\./g,"");num=num.replace(/,/,".");num=parseFloat(num);return(isNaN(num)?0:num);}function ts_sort_generic(a,b){if((typeof a[1]=="string")&&(typeof b[1]=="string")){var aa=a[1].toLowerCase();var bb=b[1].toLowerCase();return(aa.localeCompare(bb));}else{return a[1]<b[1]?-1:a[1]>b[1]?1:a[2]-b[2];}}var wma_settings={buttonImage:"//upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Erioll_world.svg/15px-Erioll_world.svg.png"};var autoCollapse=2;var collapseCaption="ocultar";var expandCaption="mostrar";function collapseTable(tableIndex){var Button=document.getElementById("collapseButton"+tableIndex);var Table=document.getElementById("collapsibleTable"+tableIndex);if(!Table||!Button){return false;}var Rows=Table.rows;if(
Button.firstChild.data==collapseCaption){for(var i=1;i<Rows.length;i++){Rows[i].style.display="none";}Button.firstChild.data=expandCaption;}else{for(var i=1;i<Rows.length;i++){Rows[i].style.display=Rows[0].style.display;}Button.firstChild.data=collapseCaption;}}function createCollapseButtons(){hito("C createCollapseButtons");var tableIndex=0;var NavigationBoxes=new Object();var Tables=document.getElementsByTagName("table");for(var i=0;i<Tables.length;i++){if(hasClass(Tables[i],"collapsible")){var HeaderRow=Tables[i].getElementsByTagName("tr")[0];if(!HeaderRow)continue;var Header=HeaderRow.getElementsByTagName("th")[0];if(!Header)continue;NavigationBoxes[tableIndex]=Tables[i];Tables[i].setAttribute("id","collapsibleTable"+tableIndex);var Button=document.createElement("span");var ButtonLink=document.createElement("a");var ButtonText=document.createTextNode(collapseCaption);Button.style.styleFloat="right";Button.style.cssFloat="right";Button.style.fontWeight="normal";Button.style.
textAlign="right";Button.style.width="6em";ButtonLink.style.color=Header.style.color;ButtonLink.setAttribute("id","collapseButton"+tableIndex);ButtonLink.setAttribute("href","javascript:collapseTable("+tableIndex+");");ButtonLink.appendChild(ButtonText);Button.appendChild(document.createTextNode("["));Button.appendChild(ButtonLink);Button.appendChild(document.createTextNode("]"));Header.insertBefore(Button,Header.childNodes[0]);tableIndex++;}}for(var i=0;i<tableIndex;i++){if(hasClass(NavigationBoxes[i],"collapsed")||(tableIndex>=autoCollapse&&hasClass(NavigationBoxes[i],"autocollapse"))){collapseTable(i);}}hito("F createCollapseButtons");}$(createCollapseButtons);var NavigationBarHide='Plegar';var NavigationBarShow='Desplegar';var NavigationBarShowDefault=0;importScript('MediaWiki:NavigationBar.js');function LinkFGA(){hito("C LinkFGA");for(var i=0;a=document.getElementsByTagName("span")[i];i++){if(a.className=="destacado"){for(var j=0;b=document.getElementsByTagName("li")[j];j++){if(b.
className=="interwiki-"+a.id){b.className+=" destacado";b.title="Este es un artículo destacado en esta Wikipedia.";}}}else if(a.className=="bueno"){for(var j=0;b=document.getElementsByTagName("li")[j];j++){if(b.className=="interwiki-"+a.id){b.className+=" bueno";b.title="Este es un artículo bueno en esta Wikipedia.";}}}}hito("F LinkFGA");}$(LinkFGA);mw.util.addCSS('#interProject {display: none; speak: none;} #p-tb .pBody {padding-right: 0;}');function iProject(){hito("C iProject");var elementos=new Array();if(document.getElementsByClassName){elementos=document.getElementsByClassName("interProject");}else{var els=document.getElementsByTagName("span");var elsLen=els.length;for(i=0,j=0;i<elsLen;i++){if("interProject"==els[i].className){elementos[j]=els[i];j++;}}}if(elementos.length>0){var portal=document.createElement('div');portal.setAttribute("class","portlet portal");var tit=document.createElement('h5');tit.setAttribute("lang","es");tit.appendChild(document.createTextNode(
'Otros proyectos'));portal.appendChild(tit);var IPY=document.createElement('div');IPY.setAttribute('class',"pBody body");var ul=document.createElement('ul');IPY.appendChild(ul);for(i=0;i<elementos.length;i++){var li=document.createElement('li');li.innerHTML=elementos[i].innerHTML;ul.appendChild(li);}portal.appendChild(IPY);if(document.getElementById("p-tb").nextSibling)document.getElementById("p-tb").parentNode.insertBefore(portal,document.getElementById("p-tb").nextSibling);else document.getElementById("p-tb").parentNode.appendChild(portal);}hito("F iProject");}$(iProject);importScript('MediaWiki:Wikibugs.js');if(typeof String.prototype.escapeRE==='undefined'){String.prototype.escapeRE=function(){return this.replace(/([\\{}()|.?*+^$\[\]])/g,"\\$1");};}hito("F Common.js");if(((wgAction=="edit")||(wgAction=="submit"))&&!wgWikiEditorEnabledModules.toolbar)importScript('MediaWiki:Edittools.javascript');importScript('MediaWiki:Comillas.js');;mw.loader.state({"site":"ready"});

/* cache key: eswiki:resourceloader:filter:minify-js:4:93f7e064edf06f66b99586c92c0ad80e */