.class Lcom/apportable/ui/Label$8;
.super Ljava/lang/Object;
.source "Label.java"

# interfaces
.implements Ljava/lang/Runnable;


# annotations
.annotation system Ldalvik/annotation/EnclosingMethod;
    value = Lcom/apportable/ui/Label;->setMinimumFontSize(F)V
.end annotation

.annotation system Ldalvik/annotation/InnerClass;
    accessFlags = 0x0
    name = null
.end annotation


# instance fields
.field final synthetic this$0:Lcom/apportable/ui/Label;

.field final synthetic val$sz:F


# direct methods
.method constructor <init>(Lcom/apportable/ui/Label;F)V
    .locals 0
    .parameter
    .parameter

    .prologue
    .line 350
    iput-object p1, p0, Lcom/apportable/ui/Label$8;->this$0:Lcom/apportable/ui/Label;

    iput p2, p0, Lcom/apportable/ui/Label$8;->val$sz:F

    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    return-void
.end method


# virtual methods
.method public run()V
    .locals 2

    .prologue
    .line 353
    iget-object v0, p0, Lcom/apportable/ui/Label$8;->this$0:Lcom/apportable/ui/Label;

    #getter for: Lcom/apportable/ui/Label;->mTextView:Lcom/apportable/ui/Label$LabelView;
    invoke-static {v0}, Lcom/apportable/ui/Label;->access$000(Lcom/apportable/ui/Label;)Lcom/apportable/ui/Label$LabelView;

    move-result-object v0

    iget v1, p0, Lcom/apportable/ui/Label$8;->val$sz:F

    invoke-virtual {v0, v1}, Lcom/apportable/ui/Label$LabelView;->setMinTextSize(F)V

    .line 354
    return-void
.end method