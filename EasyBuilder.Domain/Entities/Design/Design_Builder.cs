using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Design
{
    [Table("Design_Builder")]
    public class Design_Builder
    {
        [Key]
        public Guid Key { get; set; }

        //属性
        public string id { get; set; }
        public string title { get; set; }
        public string iconCls { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public int? left { get; set; }
        public int? top { get; set; }
        public string cls { get; set; }
        public string headerCls { get; set; }
        public string bodyCls { get; set; }
        public string style { get; set; }
        public bool? fit { get; set; }
        public bool? border { get; set; }
        public bool? doSize { get; set; }
        public bool? noheader { get; set; }
        public string content { get; set; }
        public bool? collapsible { get; set; }
        public bool? minimizable { get; set; }
        public bool? maximizable { get; set; }
        public bool? closable { get; set; }
        public object tools { get; set; }
        public bool? collapsed { get; set; }
        public bool? minimized { get; set; }
        public bool? maximized { get; set; }
        public bool? closed { get; set; }
        public string href { get; set; }
        public bool? cache { get; set; }
        public string loadingMessage { get; set; }
        public string extractor { get; set; }
        public string selected { get; set; }
        public bool? animate { get; set; }
        public bool? multiple { get; set; }
        public int? firstDay { get; set; }
        public int? weeks { get; set; }
        public int? months { get; set; }
        public int? year { get; set; }
        public int? month { get; set; }
        public int? current { get; set; }
        public int? panelWidth { get; set; }
        public int? panelHeight { get; set; }
        public bool? selectOnNavigation { get; set; }
        public string separator { get; set; }
        public bool? editable { get; set; }
        public bool? disabled { get; set; }
        public bool? hasDownArrow { get; set; }
        public string value { get; set; }
        public int? delay { get; set; }
        public object keyHandler { get; set; }
        public string valueField { get; set; }
        public string textField { get; set; }
        public string groupField { get; set; }
        public string groupFormatter { get; set; }
        public string mode { get; set; }
        public string url { get; set; }
        public string method { get; set; }
        public string data { get; set; }
        public string filter { get; set; }
        public string formatter { get; set; }
        public string loader { get; set; }
        public string loadFilter { get; set; }
        public string loadMsg { get; set; }
        public string idField { get; set; }
        public object columns { get; set; }
        public object frozenColumns { get; set; }
        public bool? fitColumns { get; set; }
        public string resizeHandle { get; set; }
        public bool? autoRowHeight { get; set; }
        public object toolbar { get; set; }
        public bool? striped { get; set; }
        public bool? nowrap { get; set; }
        public bool? pagination { get; set; }
        public bool? rownumbers { get; set; }
        public bool? singleSelect { get; set; }
        public bool? checkOnSelect { get; set; }
        public bool? selectOnCheck { get; set; }
        public string pagePosition { get; set; }
        public int? pageNumber { get; set; }
        public int? pageSize { get; set; }
        public object pageList { get; set; }
        public object queryParams { get; set; }
        public string sortName { get; set; }
        public string sortOrder { get; set; }
        public bool? multiSort { get; set; }
        public bool? remoteSort { get; set; }
        public bool? showHeader { get; set; }
        public bool? showFooter { get; set; }
        public int? scrollbarSize { get; set; }
        public object editors { get; set; }
        public object view { get; set; }
        public string currentText { get; set; }
        public string closeText { get; set; }
        public string okText { get; set; }
        public object buttons { get; set; }
        public string sharedCalendar { get; set; }
        public string field { get; set; }
        public int? rowspan { get; set; }
        public int? colspan { get; set; }
        public string align { get; set; }
        public string halign { get; set; }
        public bool? sortable { get; set; }
        public string order { get; set; }
        public bool? resizable { get; set; }
        public bool? hidden { get; set; }
        public bool? checkbox { get; set; }
        public object editor { get; set; }
        public bool? showSeconds { get; set; }
        public string timeSeparator { get; set; }
        public int? zIndex { get; set; }
        public bool? draggable { get; set; }
        public bool? shadow { get; set; }
        public bool? inline { get; set; }
        public bool? modal { get; set; }
        public bool? toggle { get; set; }
        public string group { get; set; }
        public bool? plain { get; set; }
        public string text { get; set; }
        public string iconAlign { get; set; }
        public int? min { get; set; }
        public int? max { get; set; }
        public int? precision { get; set; }
        public string decimalSeparator { get; set; }
        public string groupSeparator { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public bool? required { get; set; }
        public object validType { get; set; }
        public string missingMessage { get; set; }
        public string invalidMessage { get; set; }
        public string tipPosition { get; set; }
        public int? deltaX { get; set; }
        public bool? novalidate { get; set; }
        public bool? showGroup { get; set; }
        public int? scrollIncrement { get; set; }
        public int? scrollDuration { get; set; }
        public string toolPosition { get; set; }
        public string tabPosition { get; set; }
        public int? headerWidth { get; set; }
        public int? tabWidth { get; set; }
        public int? tabHeight { get; set; }
        public bool? cascadeCheck { get; set; }
        public bool? onlyLeafCheck { get; set; }
        public bool? lines { get; set; }
        public bool? dnd { get; set; }
        public string treeField { get; set; }

        public virtual Design_Function handler { get; set; }

        //事件
        public virtual Design_Function onSelect { get; set; }
        public virtual Design_Function onUnselect { get; set; }
        public virtual Design_Function onAdd { get; set; }
        public virtual Design_Function onBeforeRemove { get; set; }
        public virtual Design_Function onRemove { get; set; }
        public virtual Design_Function onShowPanel { get; set; }
        public virtual Design_Function onHidePanel { get; set; }
        public virtual Design_Function onChange { get; set; }
        public virtual Design_Function onBeforeLoad { get; set; }
        public virtual Design_Function onLoadSuccess { get; set; }
        public virtual Design_Function onLoadError { get; set; }
        public virtual Design_Function onClickRow { get; set; }
        public virtual Design_Function onDblClickRow { get; set; }
        public virtual Design_Function onClickCell { get; set; }
        public virtual Design_Function onDblClickCell { get; set; }
        public virtual Design_Function onSortColumn { get; set; }
        public virtual Design_Function onResizeColumn { get; set; }
        public virtual Design_Function onSelectAll { get; set; }
        public virtual Design_Function onUnselectAll { get; set; }
        public virtual Design_Function onCheck { get; set; }
        public virtual Design_Function onUncheck { get; set; }
        public virtual Design_Function onCheckAll { get; set; }
        public virtual Design_Function onUncheckAll { get; set; }
        public virtual Design_Function onBeforeEdit { get; set; }
        public virtual Design_Function onAfterEdit { get; set; }
        public virtual Design_Function onCancelEdit { get; set; }
        public virtual Design_Function onHeaderContextMenu { get; set; }
        public virtual Design_Function onRowContextMenu { get; set; }
        public virtual Design_Function onLoad { get; set; }
        public virtual Design_Function onBeforeOpen { get; set; }
        public virtual Design_Function onOpen { get; set; }
        public virtual Design_Function onBeforeClose { get; set; }
        public virtual Design_Function onClose { get; set; }
        public virtual Design_Function onBeforeDestroy { get; set; }
        public virtual Design_Function onDestroy { get; set; }
        public virtual Design_Function onBeforeCollapse { get; set; }
        public virtual Design_Function onCollapse { get; set; }
        public virtual Design_Function onBeforeExpand { get; set; }
        public virtual Design_Function onExpand { get; set; }
        public virtual Design_Function onResize { get; set; }
        public virtual Design_Function onMove { get; set; }
        public virtual Design_Function onMaximize { get; set; }
        public virtual Design_Function onRestore { get; set; }
        public virtual Design_Function onMinimize { get; set; }
        public virtual Design_Function onSubmit { get; set; }
        public virtual Design_Function success { get; set; }
        public virtual Design_Function  onUpdate { get; set; }
        public virtual Design_Function onClick { get; set; }
        public virtual Design_Function onDblClick { get; set; }
        public virtual Design_Function onBeforeCheck { get; set; }
        public virtual Design_Function onBeforeSelect { get; set; }
        public virtual Design_Function onContextMenu { get; set; }
        public virtual Design_Function onBeforeDrag { get; set; }
        public virtual Design_Function onStartDrag { get; set; }
        public virtual Design_Function onStopDrag { get; set; }
        public virtual Design_Function onDragEnter { get; set; }
        public virtual Design_Function onDragOver { get; set; }
        public virtual Design_Function onDragLeave { get; set; }
        public virtual Design_Function onBeforeDrop { get; set; }
        public virtual Design_Function onDrop { get; set; }
        
    }
}
