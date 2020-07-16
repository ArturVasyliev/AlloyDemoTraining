define([
    "dojo/_base/declare",
    "dojo/dom-construct",
    "dojo/dom-class",
    "dojo/on",
    "epi/_Module",
    "epi-cms/component/Media",
    "xstyle/css!./media-gallery.css"
], function (
    declare,
    domConstruct,
    domClass,
    on,
    module,
    MediaComponent
) {
    return declare([module], {

        initialize: function () {
            this.inherited(arguments);

            var original = MediaComponent.prototype.buildRendering;
            MediaComponent.prototype.buildRendering = function () {
                original.apply(this, arguments);

                var changeViewEl = domConstruct.create("a", { "class": "view-type epi-icon--medium epi-iconSegments" });
                var container = domConstruct.create("div", { "class": "view-type-selector" });
                container.appendChild(changeViewEl);

                function changeView(e) {
                    var isList = domClass.contains(e.target, "epi-iconSegments");
                    var cssClass = isList ? "epi-iconList" : "epi-iconSegments";
                    var listClass = isList ? "gallery" : "list";
                    domClass.replace(e.target, cssClass, "epi-iconList epi-iconSegments");
                    domClass.replace(this.list.grid.domNode, listClass, 'list gallery');
                }
                this.own(on(changeViewEl, "click", changeView.bind(this)));
                var parentEl = this.list.domNode.parentElement.querySelector(".epi-createContentContainer");
                parentEl.insertBefore(container, parentEl.firstChild);
            }
        }
    });
});