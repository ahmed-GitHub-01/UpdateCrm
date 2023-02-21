Imports System.Data.SqlClient
Imports System.Net

Public Class CLS_ENTER_USER
    Public Function ADD_ROULE(CODE As Double)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("INSERT INTO [dbo].[ROULE] (CODE_EMP)
                        VALUES
                       (" & CODE & ")")
    End Function
    Public Function NAME_2(CODE_ As Integer)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT  CODE, NAME, PASS, PIC, IS_VOKE, ACTIVEE FROM dbo.EMPLOYEE WHERE (CODE = " & CODE_ & ")")
        Return DT
    End Function
    Public Function NAME_(CODE_ As Integer)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT  CODE, NAME, PASS, PIC FROM dbo.EMPLOYEE WHERE (CODE = " & CODE_ & ")")
        Return DT
    End Function
    Public Function PASS_(PASS As String, CODE_ As Integer)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT PASS, CODE, RESPON, NAME, MACADDRESS, VALID_MAC, VALID_USER FROM  dbo.EMPLOYEE WHERE  (PASS = '" & PASS & "') AND (CODE = " & CODE_ & ")")
        Return DT
    End Function
    Public Function LOGIN(USERNAME As Integer, PASSWORD As String)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT PASS, CODE, RESPON, NAME, MACADDRESS, VALID_MAC, VALID_USER, DEPARTMENT
                             FROM  dbo.EMPLOYEE WHERE  (PASS = '" & PASSWORD & "') AND (CODE = " & USERNAME & ")")
        Return DT
    End Function
    Public Function NAME_EMPLOYE(USER As Integer)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT NAME FROM  dbo.EMPLOYEE WHERE (CODE = " & USER & ")")
        Return DT
    End Function
    Public Function GET_NAME()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT dbo.ROULE.CODE_EMP AS [كود الموظف], dbo.EMPLOYEE.NAME AS الاسم, dbo.ROULE.ROULE AS الصلاحية, dbo.ROULE.UPLOAD_FILE AS [رفع الملفات], 
                         dbo.ROULE.ADD_PAY AS [اضافة سداد], dbo.ROULE.ATTEND AS الحضور, dbo.ROULE.NUMBER AS [رفع ارقام], 
                         dbo.ROULE.Arrange_customer_entry AS [تنظيم دخول العملاء], dbo.ROULE.Waiting_customers AS [انتظار العملاء], dbo.ROULE.Search_statements AS [البحث فى الافادات], 
                         dbo.ROULE.FINANCE AS [الادارة المالية], dbo.ROULE.EDIT_CODE_EMPLOYEE_EXCEL AS [تعديل اكواد للموظفين باكسيل], 
                         dbo.ROULE.EDIT_CODE_EMPLOYEE_NONEXCEL AS [تعديل كواد للموظفين], dbo.ROULE.IMPORT_FROM_EXCEL AS [استيراد من الاكسيل], 
                         dbo.ROULE.IMPLEMENTATION AS التنفيذ, dbo.ROULE.REPORT AS التقارير, dbo.ROULE.STOP_WORK AS [ايقاف العمل], dbo.ROULE.EDIT_CASE AS [تعديل الحالات], 
                         dbo.ROULE.CASE_ AS [تعديل الحالة], dbo.ROULE.STAT_SEC AS [افادات السكرتارية], dbo.ROULE.RECIVED AS [استلام السندات], dbo.ROULE.ISTEMARA AS الاستمارة, 
                         dbo.ROULE.STATMENT_INFO AS [معلومات الافادة], dbo.ROULE.CPTURE_CND AS [سندات القبض], dbo.ROULE.UPDATE_GROUB AS [تعديل مجموعة لموظف], 
                         dbo.ROULE.UDPATE_CODE_GROUB AS [تعديل اكواد للمجموعات],dbo.ROULE.UPDATE_AUTO_NUM AS [رفع الرقم الالى],dbo.ROULE.EDIT_SND AS [تعديل سند قبض],
                         dbo.ROULE.TRANSFER_TO_COMPANY AS [التحويل الى الشركات],dbo.ROULE.ADD_NOT4 AS [ادخال ملاحظات 4 باكسيل],dbo.ROULE.ADD_OHDA AS [ادخال العهد],dbo.ROULE.REVIEWANDINVOICE AS [مراجعه العهد وارسال الفواتير],
                         dbo.ROULE.ACC_REPORT AS [التفارير المالية],dbo.ROULE.NEW_MOKEL AS [اضافة موكل جديد],dbo.ROULE.NUM_STAT AS [تقرير عدد الافادات],dbo.ROULE.CLOSED AS [اقفال الملفات],dbo.ROULE.NOTE_5 AS [اضافة ملاحظات 5],
                         dbo.ROULE.PROCE AS [رفع الاجراءات],dbo.ROULE.ACC_PAYMENT AS [كشف حساب السيارات],dbo.ROULE.BATCH_ZAIN AS [باتشات زين],dbo.ROULE.AUTO_NUM AS [اضافة ارقام الية],dbo.ROULE.CLASSIFICATION AS [اضافة تصنيفات],
                         dbo.ROULE.BATCHES_PRE AS [نسب باتشات زين],dbo.ROULE.FILE_TO_IMP AS [توزيع الملفات للتنفيذ],dbo.ROULE.DAILY_REPORT AS [تقرير السداد اليومى],dbo.ROULE.PRINT_FILE AS [تجهيز الملفات لرفعها اون لاين],
                         dbo.ROULE.ADD_COURT AS [تعديل المحاكم للملفات],dbo.ROULE.ADD_NOTE_WORK AS [تعديل ملاحظات العمل],dbo.ROULE.UPDATE_CIVIL_NAME AS [تعديل المدنى والاسم والعنوان والجنسية],dbo.ROULE.UPDATE_MAIL AS [تعديل تاريخ البعثيات],
                         dbo.ROULE.COURT_DKHLIA_CIVIL AS [تغيير اسم المحكمة وحالة الداخلية والمدنية قسم السكرتارية],dbo.ROULE.SND_EX_CUSTOMER AS [الاستعلام عن العملاء المحولين الى الشركة بسند صرف] ,dbo.ROULE.REC_AHKAM AS [استلام واعلان الصيغة التنفيذية] ,
                         dbo.ROULE.DOWNLAD_SND AS [تحميل السندات من الاونلاين],dbo.ROULE.ADD_MDL_FILE AS [اضافة ملف متداول جديد],dbo.ROULE.ROOL AS [طباعة الرول]
                         ,dbo.ROULE.TOTAL_COMPANY AS [تقرير اجمالى الشركات],dbo.ROULE.ALL_TRARGET AS [التارجيت العام],dbo.ROULE.EDIT_COMMETIONS AS [تعديل العمولة],
                         dbo.ROULE.TAWKELAT AS [الاطلاع على التوكيلات],dbo.ROULE.CAR_BALANCE AS  [كشف حساب السيارات],dbo.ROULE.COLLECTIONBYYEARFORMONTH AS [تقرير التحصيل بالسنوات والاشهر],dbo.ROULE.UNCOLLECTIBLE AS [الغير قابل للتحصيل],
                         dbo.ROULE.OhdaReviewSec AS [استلام العهدة من السكرتارية], dbo.ROULE.REPORT_BRANCH AS [تقارير الافرع],dbo.ROULE.TOOAN_DATE AS [تعديل تاريخ الطعن],dbo.ROULE.ACC_COLLECTION AS [التحصيل من الموكلين],dbo.ROULE.KSHF_TOAN AS [كشف الطعون],
                         dbo.ROULE.IMP_CLASSIFICATION AS [اضافة تصنيفات للافادات فى التنفيذ],dbo.ROULE.RECIVIED_FILE_FROM_CLIENT AS [استلام الكشوف المرسلة من الموكلين],dbo.ROULE.ADD_PROSECUTOR AS [اضافة وتعديل المدعى القانونى],dbo.ROULE.MDL_REPORT AS [تقارير المتداول],
                         dbo.ROULE.GETMACADDRESS AS [MAC Address], dbo.ROULE.IMPLEMENT_FILE AS [مراجعة التنفيذ الجديد],dbo.ROULE.TRANSPORT_HOKM AS [صلاحية ترحيل الاحكام], dbo.ROULE.EXPORT_TO_COMPANY AS [الصادر والوارد], dbo.ROULE.BULK_SMS AS [BULK SMS],
                         dbo.ROULE.RECIVIED_HOKM AS [استلام الاحكام],dbo.ROULE.AUTO_DAILER AS [رفع افادات الاوتودايلر],dbo.ROULE.FinalProcess AS [تقرير الاجراءات النهائية للتنفيذ],dbo.ROULE.AutoDailerReport AS [تقرير الاوتو دايلر]
                         FROM dbo.EMPLOYEE INNER JOIN
                         dbo.ROULE ON dbo.EMPLOYEE.CODE = dbo.ROULE.CODE_EMP")
        Return DT
    End Function
    Public Function GET_SEARCH(NAME_ As String)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT dbo.ROULE.CODE_EMP AS [كود الموظف], dbo.EMPLOYEE.NAME AS الاسم, dbo.ROULE.ROULE AS الصلاحية, dbo.ROULE.UPLOAD_FILE AS [رفع الملفات], 
                         dbo.ROULE.ADD_PAY AS [اضافة سداد], dbo.ROULE.ATTEND AS الحضور, dbo.ROULE.NUMBER AS [رفع ارقام], 
                         dbo.ROULE.Arrange_customer_entry AS [تنظيم دخول العملاء], dbo.ROULE.Waiting_customers AS [انتظار العملاء], dbo.ROULE.Search_statements AS [البحث فى الافادات], 
                         dbo.ROULE.FINANCE AS [الادارة المالية], dbo.ROULE.EDIT_CODE_EMPLOYEE_EXCEL AS [تعديل اكواد للموظفين باكسيل], 
                         dbo.ROULE.EDIT_CODE_EMPLOYEE_NONEXCEL AS [تعديل كواد للموظفين], dbo.ROULE.IMPORT_FROM_EXCEL AS [استيراد من الاكسيل], 
                         dbo.ROULE.IMPLEMENTATION AS التنفيذ, dbo.ROULE.REPORT AS التقارير, dbo.ROULE.STOP_WORK AS [ايقاف العمل], dbo.ROULE.EDIT_CASE AS [تعديل الحالات], 
                         dbo.ROULE.CASE_ AS [تعديل الحالة], dbo.ROULE.STAT_SEC AS [افادات السكرتارية], dbo.ROULE.RECIVED AS [استلام السندات], dbo.ROULE.ISTEMARA AS الاستمارة, 
                         dbo.ROULE.STATMENT_INFO AS [معلومات الافادة], dbo.ROULE.CPTURE_CND AS [سندات القبض], dbo.ROULE.UPDATE_GROUB AS [تعديل مجموعة لموظف], 
                         dbo.ROULE.UDPATE_CODE_GROUB AS [تعديل اكواد للمجموعات],dbo.ROULE.UPDATE_AUTO_NUM AS [رفع الرقم الالى],dbo.ROULE.EDIT_SND AS [تعديل سند قبض],
                         dbo.ROULE.TRANSFER_TO_COMPANY AS [التحويل الى الشركات],dbo.ROULE.ADD_NOT4 AS [ادخال ملاحظات 4 باكسيل],dbo.ROULE.ADD_OHDA AS [ادخال العهد],dbo.ROULE.REVIEWANDINVOICE AS [مراجعه العهد وارسال الفواتير],
                         dbo.ROULE.ACC_REPORT AS [التفارير المالية],dbo.ROULE.NEW_MOKEL AS [اضافة موكل جديد],dbo.ROULE.NUM_STAT AS [تقرير عدد الافادات],dbo.ROULE.CLOSED AS [اقفال الملفات],dbo.ROULE.NOTE_5 AS [اضافة ملاحظات 5],
                         dbo.ROULE.PROCE AS [رفع الاجراءات],dbo.ROULE.ACC_PAYMENT AS [كشف حساب السيارات],dbo.ROULE.BATCH_ZAIN AS [باتشات زين],dbo.ROULE.AUTO_NUM AS [اضافة ارقام الية],dbo.ROULE.CLASSIFICATION AS [اضافة تصنيفات],
                         dbo.ROULE.BATCHES_PRE AS [نسب باتشات زين],dbo.ROULE.FILE_TO_IMP AS [توزيع الملفات للتنفيذ],dbo.ROULE.DAILY_REPORT AS [تقرير السداد اليومى],dbo.ROULE.PRINT_FILE AS [تجهيز الملفات لرفعها اون لاين],
                         dbo.ROULE.ADD_COURT AS [تعديل المحاكم للملفات],dbo.ROULE.ADD_NOTE_WORK AS [تعديل ملاحظات العمل],dbo.ROULE.UPDATE_CIVIL_NAME AS [تعديل المدنى والاسم والعنوان والجنسية],dbo.ROULE.UPDATE_MAIL AS [تعديل تاريخ البعثيات],
                         dbo.ROULE.COURT_DKHLIA_CIVIL AS [تغيير اسم المحكمة وحالة الداخلية والمدنية قسم السكرتارية],dbo.ROULE.SND_EX_CUSTOMER AS [الاستعلام عن العملاء المحولين الى الشركة بسند صرف] ,dbo.ROULE.REC_AHKAM AS [استلام واعلان الصيغة التنفيذية] ,
                         dbo.ROULE.DOWNLAD_SND AS [تحميل السندات من الاونلاين],dbo.ROULE.ADD_MDL_FILE AS [اضافة ملف متداول جديد],dbo.ROULE.ROOL AS [طباعة الرول],dbo.ROULE.TOTAL_COMPANY AS [تقرير اجمالى الشركات],dbo.ROULE.ALL_TRARGET AS [التارجيت العام],
                         dbo.ROULE.EDIT_COMMETIONS AS [تعديل العمولة],dbo.ROULE.TAWKELAT AS [الاطلاع على التوكيلات],dbo.ROULE.CAR_BALANCE AS  [كشف حساب السيارات],dbo.ROULE.COLLECTIONBYYEARFORMONTH AS [تقرير التحصيل بالسنوات والاشهر],dbo.ROULE.UNCOLLECTIBLE AS [الغير قابل للتحصيل],
                         dbo.ROULE.OhdaReviewSec AS [استلام العهدة من السكرتارية],dbo.ROULE.REPORT_BRANCH AS [تقارير الافرع],dbo.ROULE.TOOAN_DATE AS [تعديل تاريخ الطعن],dbo.ROULE.ACC_COLLECTION AS [التحصيل من الموكلين],dbo.ROULE.KSHF_TOAN AS [كشف الطعون],
                         dbo.ROULE.IMP_CLASSIFICATION AS [اضافة تصنيفات للافادات فى التنفيذ],dbo.ROULE.RECIVIED_FILE_FROM_CLIENT AS [استلام الكشوف المرسلة من الموكلين],dbo.ROULE.ADD_PROSECUTOR AS [اضافة وتعديل المدعى القانونى],dbo.ROULE.MDL_REPORT AS [تقارير المتداول],
                         dbo.ROULE.GETMACADDRESS AS [MAC Address], dbo.ROULE.IMPLEMENT_FILE AS [مراجعة التنفيذ الجديد],dbo.ROULE.TRANSPORT_HOKM AS [صلاحية ترحيل الاحكام], dbo.ROULE.EXPORT_TO_COMPANY AS [الصادر والوارد], dbo.ROULE.BULK_SMS AS [BULK SMS],
                         dbo.ROULE.RECIVIED_HOKM AS [استلام الاحكام],dbo.ROULE.AUTO_DAILER AS [رفع افادات الاوتودايلر],dbo.ROULE.FinalProcess AS [تقرير الاجراءات النهائية للتنفيذ],dbo.ROULE.AutoDailerReport AS [تقرير الاوتو دايلر]
                         FROM dbo.EMPLOYEE INNER JOIN
                         dbo.ROULE ON dbo.EMPLOYEE.CODE = dbo.ROULE.CODE_EMP
                         WHERE (dbo.EMPLOYEE.NAME LIKE '%" & NAME_ & "%')")
        Return DT
    End Function
    Public Sub SAVE_ROULUS(CODE_EMP As Double, ROULE As Integer, UPLOAD_FILE As Integer,
                           ADD_PAY As Integer, ATTEND As Integer, NUMBER As Integer,
                           Arrange_customer_entry As Integer, Waiting_customers As Integer, Search_statements As Integer,
                           FINANCE As Integer, EDIT_CODE_EMPLOYEE_EXCEL As Integer, EDIT_CODE_EMPLOYEE_NONEXCEL As Integer,
                           IMPORT_FROM_EXCEL As Integer, IMPLEMENTATION As Integer, REPORT As Integer,
                           STOP_WORK As Integer, EDIT_CASE As Integer, CASE_ As Integer,
                           STAT_SEC As Integer, RECIVED As Integer, ISTEMARA As Integer,
                           STATMENT_INFO As Integer, CPTURE_CND As Integer, UPDATE_GROUB As Integer,
                           UDPATE_CODE_GROUB As Integer, UPDATE_AUTO_NUM As Integer, EDIT_SND As Integer,
                           TRANSFER_TO_COMPANY As Integer, ADD_NOT4 As Integer, ADD_OHDA As Integer,
                           REVIEWANDINVOICE As Integer, ACC_REPORT As Integer, NEW_MOKEL As Integer,
                           NUM_STAT As Integer, CLOSED As Integer, NOTE_5 As Integer, PROCE As Integer,
                           ACC_PAYMENT As Integer, BATCH_ZAIN As Integer, AUTO_NUM As Integer,
                           CLASSIFICATION As Integer, BATCHES_PRE As Integer, FILE_TO_IMP As Integer,
                           DAILY_REPORT As Integer, PRINT_FILE As Integer, ADD_COURT As Integer,
                           ADD_NOTE_WORK As Integer, UPDATE_CIVIL_NAME As Integer, UPDATE_MAIL As Integer,
                           COURT_DKHLIA_CIVIL As Integer, SND_EX_CUSTOMER As Integer, REC_AHKAM As Integer,
                           DOWNLAD_SND As Integer, ADD_MDL_FILE As Integer, ROOL As Integer,
                           TOTAL_COMPANY As Integer, ALL_TRARGET As Integer, EDIT_COMMETIONS As Integer, TAWKELAT As Integer,
                           CAR_BALANCE As Integer, COLLECTIONBYYEARFORMONTH As Integer, UNCOLLECTIBLE As Integer, OhdaReviewSec As Integer,
                           REPORT_BRANCH As Integer, TOOAN_DATE As Integer, ACC_COLLECTION As Integer, KSHF_TOAN As Integer,
                           IMP_CLASSIFICATION As Integer, RECIVIED_FILE_FROM_CLIENT As Integer, ADD_PROSECUTOR As Integer,
                           MDL_REPORT As Integer, GETMACADDRESS As Integer, IMPLEMENT_FILE As Integer,
                           TRANSPORT_HOKM As Integer, EXPORT_TO_COMPANY As Integer, BULK_SMS As Integer,
                           RECIVIED_HOKM As Integer, AUTO_DAILER As Integer, FinalProcess As Integer, AutoDailerReport As Integer)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("UPDATE [dbo].[ROULE]
                        SET [ROULE]                       = " & ROULE & "
                            ,[UPLOAD_FILE]                 = " & UPLOAD_FILE & "
                            ,[ADD_PAY]                     = " & ADD_PAY & "
                            ,[ATTEND]                      = " & ATTEND & "
                            ,[NUMBER]                      = " & NUMBER & "
                            ,[Arrange_customer_entry]      = " & Arrange_customer_entry & "
                            ,[Waiting_customers]           = " & Waiting_customers & "
                            ,[Search_statements]           = " & Search_statements & "
                            ,[FINANCE]                     = " & FINANCE & "
                            ,[EDIT_CODE_EMPLOYEE_EXCEL]    = " & EDIT_CODE_EMPLOYEE_EXCEL & "
                            ,[EDIT_CODE_EMPLOYEE_NONEXCEL] = " & EDIT_CODE_EMPLOYEE_NONEXCEL & "
                            ,[IMPORT_FROM_EXCEL]           = " & IMPORT_FROM_EXCEL & "
                            ,[IMPLEMENTATION]              = " & IMPLEMENTATION & "
                            ,[REPORT]                      = " & REPORT & "
                            ,[STOP_WORK]                   = " & STOP_WORK & "
                            ,[EDIT_CASE]                   = " & EDIT_CASE & "
                            ,[CASE_]                       = " & CASE_ & "
                            ,[STAT_SEC]                    = " & STAT_SEC & "
                            ,[RECIVED]                     = " & RECIVED & "
                            ,[ISTEMARA]                    = " & ISTEMARA & "
                            ,[STATMENT_INFO]               = " & STATMENT_INFO & "
                            ,[CPTURE_CND]                  = " & CPTURE_CND & "
                            ,[UPDATE_GROUB]                = " & UPDATE_GROUB & "
                            ,[UDPATE_CODE_GROUB]           = " & UDPATE_CODE_GROUB & "
                            ,[UPDATE_AUTO_NUM]             = " & UPDATE_AUTO_NUM & "
                            ,[EDIT_SND]                    = " & EDIT_SND & "
                            ,[TRANSFER_TO_COMPANY]         = " & TRANSFER_TO_COMPANY & "
                            ,[ADD_NOT4]                    = " & ADD_NOT4 & "
                            ,[ADD_OHDA]                    = " & ADD_OHDA & "
                            ,[REVIEWANDINVOICE]            = " & REVIEWANDINVOICE & "
                            ,[ACC_REPORT]                  = " & ACC_REPORT & "
                            ,[NEW_MOKEL]                   = " & NEW_MOKEL & "
                            ,[NUM_STAT]                    = " & NUM_STAT & "
                            ,[CLOSED]                      = " & CLOSED & "
                            ,[NOTE_5]                      = " & NOTE_5 & "
                            ,[PROCE]                       = " & PROCE & "
                            ,[ACC_PAYMENT]                 = " & ACC_PAYMENT & "
                            ,[BATCH_ZAIN]                  = " & BATCH_ZAIN & "
                            ,[AUTO_NUM]                    = " & AUTO_NUM & "
                            ,[CLASSIFICATION]              = " & CLASSIFICATION & "
                            ,[BATCHES_PRE]                 = " & BATCHES_PRE & "
                            ,[FILE_TO_IMP]                 = " & FILE_TO_IMP & "
                            ,[DAILY_REPORT]                = " & DAILY_REPORT & "
                            ,[PRINT_FILE]                  = " & PRINT_FILE & "
                            ,[ADD_COURT]                   = " & ADD_COURT & "
                            ,[ADD_NOTE_WORK]               = " & ADD_NOTE_WORK & "
                            ,[UPDATE_CIVIL_NAME]           = " & UPDATE_CIVIL_NAME & "
                            ,[UPDATE_MAIL]                 = " & UPDATE_MAIL & "
                            ,[COURT_DKHLIA_CIVIL]          = " & COURT_DKHLIA_CIVIL & "
                            ,[SND_EX_CUSTOMER]             = " & SND_EX_CUSTOMER & "
                            ,[REC_AHKAM]                   = " & REC_AHKAM & "
                            ,[DOWNLAD_SND]                 = " & DOWNLAD_SND & "
                            ,[ADD_MDL_FILE]                = " & ADD_MDL_FILE & "
                            ,[ROOL]                        = " & ROOL & "
                            ,[TOTAL_COMPANY]               = " & TOTAL_COMPANY & "
                            ,[ALL_TRARGET]                 = " & ALL_TRARGET & "
                            ,[EDIT_COMMETIONS]             = " & EDIT_COMMETIONS & "
                            ,[TAWKELAT]                    = " & TAWKELAT & "
                            ,[CAR_BALANCE]                 = " & CAR_BALANCE & "
                            ,[COLLECTIONBYYEARFORMONTH]    = " & COLLECTIONBYYEARFORMONTH & "
                            ,[UNCOLLECTIBLE]               = " & UNCOLLECTIBLE & "
                            ,[OhdaReviewSec]               = " & OhdaReviewSec & "
                            ,[REPORT_BRANCH]               = " & REPORT_BRANCH & "
                            ,[TOOAN_DATE]                  = " & TOOAN_DATE & "
                            ,[ACC_COLLECTION]              = " & ACC_COLLECTION & "
                            ,[KSHF_TOAN]                   = " & KSHF_TOAN & "
                            ,[IMP_CLASSIFICATION]          = " & IMP_CLASSIFICATION & " 
                            ,[RECIVIED_FILE_FROM_CLIENT]   = " & RECIVIED_FILE_FROM_CLIENT & "
                            ,[ADD_PROSECUTOR]              = " & ADD_PROSECUTOR & "
                            ,[MDL_REPORT]                  = " & MDL_REPORT & "
                            ,[GETMACADDRESS]               = " & GETMACADDRESS & "
                            ,[IMPLEMENT_FILE]              = " & IMPLEMENT_FILE & "
                            ,[TRANSPORT_HOKM]              =  " & TRANSPORT_HOKM & "
                            ,[EXPORT_TO_COMPANY]           = " & EXPORT_TO_COMPANY & "
                            ,[BULK_SMS]                    = " & BULK_SMS & "
                            ,[RECIVIED_HOKM]               = " & RECIVIED_HOKM & "
                            ,[AUTO_DAILER]                 = " & AUTO_DAILER & "
                            ,[FinalProcess]                = " & FinalProcess & "
                            ,[AutoDailerReport]            = " & AutoDailerReport & "
                        WHERE CODE_EMP                     = " & CODE_EMP & "")
    End Sub
    Public Function TEST_POWER(NAME_ As String)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT        
dbo.ROULE.CODE_EMP AS [كود الموظف], 
dbo.EMPLOYEE.NAME AS الاسم, 
dbo.ROULE.ROULE AS الصلاحية,
dbo.ROULE.UPLOAD_FILE AS [رفع الملفات],     
dbo.ROULE.ADD_PAY AS [اضافة سداد],
dbo.ROULE.ATTEND AS الحضور,
dbo.ROULE.NUMBER AS [رفع ارقام], 
dbo.ROULE.Arrange_customer_entry AS [تنظيم دخول العملاء],
dbo.ROULE.Waiting_customers AS [انتظار العملاء],
dbo.ROULE.Search_statements AS [البحث فى الافادات], 
dbo.ROULE.FINANCE AS [الادارة المالية], 
dbo.ROULE.EDIT_CODE_EMPLOYEE_EXCEL AS [تعديل اكواد للموظفين باكسيل], 
dbo.ROULE.EDIT_CODE_EMPLOYEE_NONEXCEL AS [تعديل كواد للموظفين],
dbo.ROULE.IMPORT_FROM_EXCEL AS [استيراد من الاكسيل], 
dbo.ROULE.IMPLEMENTATION AS التنفيذ,
dbo.ROULE.REPORT AS التقارير,
dbo.ROULE.STOP_WORK AS [ايقاف العمل],
dbo.ROULE.EDIT_CASE AS [تعديل الحالات], 
dbo.ROULE.CASE_ AS [تعديل الحالة],
dbo.ROULE.STAT_SEC AS [افادات السكرتارية],
dbo.ROULE.RECIVED AS [استلام السندات],
dbo.ROULE.ISTEMARA AS الاستمارة, 
dbo.ROULE.STATMENT_INFO AS [معلومات الافادة], 
dbo.ROULE.CPTURE_CND AS [سندات القبض], 
dbo.ROULE.UPDATE_GROUB AS [تعديل مجموعة لموظف], 
dbo.ROULE.UDPATE_CODE_GROUB AS [تعديل اكواد للمجموعات],
dbo.ROULE.UPDATE_AUTO_NUM AS [رفع الرقم الالى],
dbo.ROULE.EDIT_SND AS [تعديل سند قبض],
dbo.ROULE.TRANSFER_TO_COMPANY AS [التحويل الى الشركات],
dbo.ROULE.ADD_NOT4 AS [ادخال ملاحظات 4 باكسيل],
dbo.ROULE.ADD_OHDA AS [ادخال العهد],
dbo.ROULE.REVIEWANDINVOICE AS [مراجعه العهد وارسال الفواتير],
dbo.ROULE.ACC_REPORT AS [التفارير المالية],
dbo.ROULE.NEW_MOKEL AS [اضافة موكل جديد],
dbo.ROULE.NUM_STAT AS [تقرير عدد الافادات],
dbo.ROULE.CLOSED AS [اقفال الملفات],
dbo.ROULE.NOTE_5 AS [اضافة ملاحظات 5],
dbo.ROULE.PROCE AS [رفع الاجراءات],
dbo.ROULE.ACC_PAYMENT AS [كشف حساب السيارات],
dbo.ROULE.BATCH_ZAIN AS [باتشات زين],
dbo.ROULE.AUTO_NUM AS [اضافة رقم الى 2],
dbo.ROULE.CLASSIFICATION AS [اضافة تصنيفات],
dbo.ROULE.BATCHES_PRE AS [نسب باتشات زين],
dbo.ROULE.FILE_TO_IMP AS [توزيع الملفات للتنفيذ],
dbo.ROULE.DAILY_REPORT AS [تقرير السداد اليومى],
dbo.ROULE.PRINT_FILE AS [تجهيز الملفات لرفعها اون لاين],
dbo.ROULE.ADD_COURT AS [تعديل اسم المحكمة للملفات],
dbo.ROULE.ADD_NOTE_WORK AS [تعديل ملاحظات العمل],
dbo.ROULE.UPDATE_CIVIL_NAME AS [تعديل المدنى والاسم والعنوان والجنسية],
dbo.ROULE.UPDATE_MAIL AS [تعديل تاريخ البعثيات],
dbo.ROULE.COURT_DKHLIA_CIVIL AS [تغيير اسم المحكمة وحالة الداخلية والمدنية قسم السكرتارية],
dbo.ROULE.SND_EX_CUSTOMER AS [الاستعلام عن العملاء المحولين الى الشركة بسند صرف] ,
dbo.ROULE.REC_AHKAM AS [استلام واعلان الصيغة التنفيذية] ,
dbo.ROULE.DOWNLAD_SND AS [تحميل السندات من الاونلاين],
dbo.ROULE.ADD_MDL_FILE AS [اضافة ملف متداول جديد],
dbo.ROULE.ROOL AS [طباعة الرول],
dbo.ROULE.TOTAL_COMPANY AS [تقرير اجمالى الشركات],
dbo.ROULE.ALL_TRARGET AS [التارجيت العام],
dbo.ROULE.EDIT_COMMETIONS AS [تعديل العمولة],
dbo.ROULE.TAWKELAT AS [الاطلاع على التوكيلات],
dbo.ROULE.CAR_BALANCE AS [كشف حساب السيارات],
dbo.ROULE.COLLECTIONBYYEARFORMONTH AS [تقرير التحصيل بالسنوات والاشهر],
dbo.ROULE.UNCOLLECTIBLE AS [الغير قابل للتحصيل],
dbo.ROULE.OhdaReviewSec AS [استلام العهدة من السكرتارية],
dbo.ROULE.REPORT_BRANCH AS [تقارير الافرع],
dbo.ROULE.TOOAN_DATE AS [تعديل تاريخ الطعن],
dbo.ROULE.ACC_COLLECTION AS [التحصيل من الموكلين],
dbo.ROULE.KSHF_TOAN AS [كشف الطعون],
dbo.ROULE.IMP_CLASSIFICATION AS [اضافة تصنيفات للافادات فى التنفيذ],
dbo.ROULE.RECIVIED_FILE_FROM_CLIENT AS [استلام الكشوف المرسلة من الموكلين],
dbo.ROULE.ADD_PROSECUTOR AS [اضافة وتعديل المدعى القانونى],
dbo.ROULE.MDL_REPORT AS [تقارير المتداول],
dbo.ROULE.GETMACADDRESS AS [MAC Address],
dbo.ROULE.IMPLEMENT_FILE AS [مراجعة التنفيذ الجديد],
dbo.ROULE.TRANSPORT_HOKM AS [صلاحية ترحيل الاحكام],
dbo.ROULE.EXPORT_TO_COMPANY AS [الصادر والوارد],
dbo.ROULE.BULK_SMS AS [Bulk SMS],
dbo.ROULE.RECIVIED_HOKM AS [استلام الاحكام],
dbo.ROULE.AUTO_DAILER AS [رفع افادات الاوتودايلر],
dbo.ROULE.FinalProcess AS [تقرير الاجراءات النهائية للتنفيذ],
dbo.ROULE.AutoDailerReport AS [تقرير الاوتو دايلر]
FROM  dbo.EMPLOYEE INNER JOIN
dbo.ROULE ON dbo.EMPLOYEE.CODE = dbo.ROULE.CODE_EMP
WHERE (dbo.ROULE.CODE_EMP='" & NAME_ & "')")
        Return DT
    End Function
    Public Function aaaaaa()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT CODE FROM dbo.REMAIN")
        Return DT
    End Function
    'Public Sub aa_aaaa(CODE As Integer, X As Boolean)
    '    Dim CON As New DataAccessLayer
    '    Dim PRM(1) As SqlParameter
    '    PRM(0) = New SqlParameter("@CODE_EMP", DbType.Double)
    '    PRM(0).Value = CODE
    '    PRM(1) = New SqlParameter("@X", DbType.Boolean)
    '    PRM(1).Value = X
    '    CON.EXECUTECOMMAND("AAAA", PRM)
    'End Sub
    Public Sub aa_AAAAAAaaaa(CODE As Integer, X As Integer)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("UPDATE [dbo].[REMAIN]
   SET [PAY] = " & X & "
 WHERE CODE=" & CODE & "")
    End Sub
    Public Function DDDD()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT dbo.MAIN.CODE, dbo.MAIN.NAME, dbo.MAIN.REASON_DUE, dbo.MAIN.BATCH_NO, dbo.MAIN.DATE_LOGIN, dbo.CLINT.CLINT, dbo.MAIN.CONTRACT_NUM, 
                         dbo.CASE_CUST.CASE_, dbo.MAIN.NATIONAL_, dbo.MAIN.CIVIL_ID, dbo.MAIN.WAFI, dbo.MAIN.CUST_ID_OFFICE1, dbo.MAIN.CUST_ID_OFFICE2, 
                         dbo.MAIN.LINE_KIND_NOTE_2, dbo.MAIN.NOTE_2, dbo.MAIN.NOTE_3, dbo.MAIN.NOTE_4, dbo.EMPLOYEE.NAME AS الموظف, dbo.MAIN.TOTAL_CLAIM, 
                         dbo.REMAIN.PAY, dbo.MAIN.NOTE
                         FROM dbo.MAIN INNER JOIN
                         dbo.CLINT ON dbo.MAIN.CODE_CLINT = dbo.CLINT.CODE_CLINT INNER JOIN
                         dbo.CASE_CUST ON dbo.MAIN.CASE_CLINT = dbo.CASE_CUST.CODE INNER JOIN
                         dbo.EMPLOYEE ON dbo.MAIN.EMPLOYE = dbo.EMPLOYEE.CODE INNER JOIN
                         dbo.REMAIN ON dbo.MAIN.CODE = dbo.REMAIN.CODE")
        Return DT
    End Function
    Public Function DDdDD()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM dbo.RZE")
        Return DT
    End Function
    Public Function TWA()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT        dbo.MAIN.CODE, dbo.CASE_CIVIL_ID.CASE_CIVIL_ID, dbo.CASE_CIVIL_ID.DKHLEA_CASE, dbo.CASE_CIVIL_ID.KHESM_CASE, 
                         dbo.CASE_CIVIL_ID.CASE_TOWASEL, dbo.CASE_CIVIL_ID.CASE_MOTWASEL, dbo.CASE_CIVIL_ID.MOTABAA_UPDATE, dbo.EMPLOYEE.DEPARTMENT, 
                         dbo.CASE_CIVIL_ID.TYPE_PAY, dbo.CASE_CIVIL_ID.AMOUNT, dbo.CASE_CIVIL_ID.ENTRY_TYPE_PAY
FROM            dbo.MAIN INNER JOIN
                         dbo.CASE_CIVIL_ID ON dbo.MAIN.CODE = dbo.CASE_CIVIL_ID.CODE INNER JOIN
                         dbo.EMPLOYEE ON dbo.MAIN.EMPLOYE = dbo.EMPLOYEE.CODE
WHERE        (dbo.EMPLOYEE.DEPARTMENT = N'EGY')")
        Return DT
    End Function
    'Select Case dbo.MAIN.CODE, dbo.MAIN.NAME, dbo.MAIN.REASON_DUE, dbo.MAIN.BATCH_NO, dbo.MAIN.EMPLOYE, dbo.MAIN.DATE_Receive, dbo.MAIN.DATE_LOGIN, 
    '                         dbo.MAIN.DATE_Withdrawal, dbo.MAIN.CONTRACT_NUM, dbo.MAIN.AUTO_NUM, dbo.MAIN.TOTAL_CLAIM, dbo.MAIN.ADDRESS, dbo.MAIN.NATIONAL_, 
    '                         dbo.MAIN.NOTE, dbo.MAIN.CIVIL_ID, dbo.MAIN.WAFI, dbo.MAIN.SUB_CUSTOMER, dbo.MAIN.CUST_ID_OFFICE1, dbo.MAIN.CUST_ID_OFFICE2, 
    '                         dbo.MAIN.LINE_KIND_NOTE_2, dbo.MAIN.NOTE_2, dbo.MAIN.NOTE_3, dbo.MAIN.NOTE_4, dbo.MAIN.GROUB_, dbo.CLINT.CLINT, 
    '                         dbo.CASE_CUST.CASE_
    'FROM            dbo.MAIN INNER JOIN
    '                         dbo.CLINT ON dbo.MAIN.CODE_CLINT = dbo.CLINT.CODE_CLINT INNER JOIN
    '                         dbo.CASE_CUST ON dbo.MAIN.CASE_CLINT = dbo.CASE_CUST.CODE

    '    Select Case dbo.STATEMENT_2.CODE, dbo.CASE_CIVIL_ID.CODE As EXPR2, dbo.CASE_CUST.CASE_, dbo.MAIN.NAME, dbo.MAIN.CIVIL_ID, dbo.MAIN.NATIONAL_, 
    '                         dbo.MAIN.REASON_DUE, dbo.MAIN.BATCH_NO, dbo.STATEMENT_2.DATE_EVENT, dbo.STATEMENT_2.DATE_REVIEW, dbo.EMPLOYEE.NAME AS EXPR1, 
    '                         dbo.CASE_EMPLOY.FILE_, dbo.STATEMENT_2.NOTE, dbo.STATEMENT_2.WAY, dbo.STATEMENT_2.CONNECT, dbo.STATEMENT_2.NUMBER, 
    '                         dbo.STATEMENT_2.HAVE, dbo.CLINT.CLINT, dbo.MAIN.CODE_CLINT
    'FROM            dbo.CLINT INNER JOIN
    '                         dbo.STATEMENT_2 INNER JOIN
    '                         dbo.MAIN ON dbo.STATEMENT_2.CODE = dbo.MAIN.CODE INNER JOIN
    '                         dbo.EMPLOYEE ON dbo.STATEMENT_2.EMPLOYEE = dbo.EMPLOYEE.CODE ON dbo.CLINT.CODE_CLINT = dbo.MAIN.CODE_CLINT INNER JOIN
    '                         dbo.CASE_CIVIL_ID INNER JOIN
    '                         dbo.CASE_EMPLOY ON dbo.CASE_CIVIL_ID.MOTABAA_UPDATE = dbo.CASE_EMPLOY.CODE ON 
    '                         dbo.STATEMENT_2.CODE = dbo.CASE_CIVIL_ID.CODE INNER JOIN
    '                         dbo.CASE_CUST ON dbo.MAIN.CASE_CLINT = dbo.CASE_CUST.CODE
    Public Function sas(CODE As Integer, COMM As Integer, REV As Date, EVE As Date)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID, CODE, DATE_EVENT, CUST_STATUS, COMMN, NUMBER, REVIEW_DATE, CONTACT_WAY, EMPLOYE, NUMBER_USER
                                FROM dbo.STATMENT
                                WHERE (CODE = " & CODE & ") AND (EMPLOYE = " & COMM & ") 
                                AND (REVIEW_DATE =" & REV & ") AND (DATE_EVENT =" & EVE & ")")
        Return DT
    End Function
    'Public Sub UPDATE_CODE(ID As Integer)
    '    Dim CON As New CLS_CON_TELE
    '    Dim PRM(0) As SqlParameter
    '    'PRM(0) = New SqlParameter("@DATE1", SqlDbType.Date)
    '    'PRM(0).Value = DATE_
    '    'PRM(0) = New SqlParameter("@ID", SqlDbType.Int)
    '    'PRM(0).Value = ID
    '    CON.EXECUTE_STORE("EDITE_DATE_PAY", PRM)
    'End Sub
    Public Function NUM(CODE As Integer)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT NUM FROM EMPLOYEE WHERE CODE=" & CODE & "")
        Return DT
    End Function
    Public Function STATMENT()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT dbo.STATMENT.ID, dbo.STATMENT.CODE, dbo.STATMENT.DATE_EVENT, dbo.STATMENT.CUST_STATUS, dbo.STATMENT.COMMN, dbo.STATMENT.NUMBER, 
                             dbo.STATMENT.REVIEW_DATE, dbo.STATMENT.CONTACT_WAY, dbo.STATMENT.EMPLOYE, dbo.STATMENT.NUMBER_USER, dbo.MAIN.CODE_CLINT, 
                             dbo.MAIN.NAME, dbo.MAIN.CONTRACT_NUM, dbo.MAIN.TOTAL_CLAIM, dbo.MAIN.NATIONAL_, dbo.REMAIN.PAY, 
                             dbo.MAIN.TOTAL_CLAIM - dbo.REMAIN.PAY AS المتبقى
                             FROM dbo.STATMENT INNER JOIN
                             dbo.MAIN ON dbo.STATMENT.CODE = dbo.MAIN.CODE INNER JOIN
                             dbo.REMAIN ON dbo.MAIN.CODE = dbo.REMAIN.CODE
                             WHERE (dbo.STATMENT.DATE_EVENT BETWEEN CONVERT(DATETIME, '2018-11-01 00:00:00', 102) AND CONVERT(DATETIME, '2018-11-25 00:00:00', 102)) AND 
                             (dbo.MAIN.CODE_CLINT = 1)  ")
        Return DT
    End Function
    Public Function pay()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT dbo.MAIN.CODE, dbo.MAIN.NAME, dbo.MAIN.REASON_DUE, dbo.MAIN.BATCH_NO, dbo.MAIN.CIVIL_ID, dbo.MAIN.TOTAL_CLAIM, dbo.MAIN.CONTRACT_NUM, 
                            dbo.CASE_CUST.CASE_, dbo.MAIN.CODE_CLINT, dbo.STATMENT.NUMBER
                            FROM dbo.MAIN INNER JOIN
                            dbo.CASE_CUST ON dbo.MAIN.CASE_CLINT = dbo.CASE_CUST.CODE INNER JOIN
                            dbo.STATMENT ON dbo.MAIN.CODE = dbo.STATMENT.CODE
                            WHERE (dbo.MAIN.CODE_CLINT = 2) AND (dbo.MAIN.BATCH_NO = N'HO51') ")
        Return DT
    End Function
    Public Sub dele(ID As Integer, BALANCE As Double, CODE As Integer)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("delete from PAY where ID=" & ID & "")
        CON.SELECT_TXT("UPDATE REMAIN SET PAY=PAY-" & BALANCE & " WHERE CODE='" & CODE & "'")
    End Sub
    Public Sub deleLET__________(CODE As Integer)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("delete from MAIN where CODE=" & CODE & "")
        CON.EXECUTE_TXT("delete from REMAIN where CODE=" & CODE & "")
        CON.EXECUTE_TXT("delete from CASE_CIVIL_ID where CODE=" & CODE & "")
    End Sub
    Public Sub UPDATE_CIVIL_ID(CODE As Double, NAME As String, MODA As Double)
        Dim CON As New CLS_CON_TELE
        'CON.EXECUTE_TXT("UPDATE CASE_CIVIL_ID SET DPLECATE=37 where ID=" & ID & "")
        'CON.EXECUTE_TXT("UPDATE MAIN SET TOTAL_CLAIM = '" & total & "' WHERE CODE=" & CODE & "")
        CON.EXECUTE_TXT("INSERT INTO CLINT (CODE_ACC,CLINT,SECTORS) VALUES (" & CODE & ",'" & NAME & "','7')")
        CON.EXECUTE_TXT("INSERT INTO [dbo].[PROSECUTOR] ([CODE],[NAME]) VALUES (" & MODA & ",'" & NAME & "')")
    End Sub
    Public Sub select_from_statment_to_egypy(NAME As String, CIVIL_ID As Double, TYPE As String, ADRESS As String)
        Dim CON As New CLS_CON_TELE
        CON.SELECT_TXT("INSERT INTO [dbo].[RELASHON]
           ([NAME], [CIVIL_ID], [TYPE], [ADRESS])
     VALUES
           (" & NAME & "," & CIVIL_ID & "," & TYPE & "," & ADRESS & ")")
    End Sub
    Public Sub UPDATE_TOTAL(ID_PAY As Double, NUM As String)
        Dim CON As New CLS_CON_TELE
        'CON.EXECUTE_TXT("UPDATE MAIN SET TOTAL_CLAIM='" & NUM & "' WHERE CODE=" & CODE & "")
        'CON.EXECUTE_TXT("update REMAIN SET PAY='" & NUM & "' WHERE CODE=" & CODE & "")
        CON.EXECUTE_TXT("UPDATE TRANSFER SET ID_PAY=" & ID_PAY & " WHERE NUMBER_D='" & NUM & "'")
    End Sub
    Public Sub DELETE_FROM_TRANS(ID As Double)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("DELETE FROM [dbo].[TRANSFER] WHERE ID=" & ID & "")
    End Sub
    Public Sub UPDATE_COURT(CODE As Double)
        Dim CON As New CLS_CON_TELE
        'CON.EXECUTE_TXT("UPDATE MAIN SET TOTAL_CLAIM='" & NUM & "' WHERE CODE=" & CODE & "")
        'CON.EXECUTE_TXT("update REMAIN SET PAY='" & NUM & "' WHERE CODE=" & CODE & "")
        CON.EXECUTE_TXT("INSERT INTO [dbo].[ROULE]
           ([CODE_EMP])
             VALUES
           (" & CODE & ")")
    End Sub
    Public Sub UPDATE_CONCREATE_NUM(CODE As Integer, REASON_DUE As String)
        Dim CON As New CLS_CON_TELE
        'CON.EXECUTE_TXT("DELETE  FROM MAIN  WHERE CODE=" & CODE & "")
        'CON.EXECUTE_TXT("DELETE  FROM REMAIN  WHERE CODE=" & CODE & "")
        'End Sub
        'Public Sub UPDATE_CONCREATE_NUM(TABLE_NAME As String, TYPE As String, INTERNAL As Double,
        '                                FULL_NAME As String, FIRST_NAME As String, SECOND_NAME As String,
        '                                THIRD_NAME As String, FORTH_NAME As String, FAMILY_NAME As String,
        '                                BIRTH_DATE As Date, CARRER As String, ADDRESS As String)
        '    Dim CON As New CLS_CON_TELE
        '    Dim PRM(11) As SqlParameter
        '    PRM(0) = New SqlParameter("@TABLE_NAME", SqlDbType.NVarChar, 5000)
        '    PRM(0).Value = TABLE_NAME
        '    PRM(1) = New SqlParameter("@TYPE", SqlDbType.NVarChar, 5000)
        '    PRM(1).Value = TYPE
        '    PRM(2) = New SqlParameter("@INTERNAL", SqlDbType.Float)
        '    PRM(2).Value = INTERNAL
        '    PRM(3) = New SqlParameter("@FULL_NAME", SqlDbType.NVarChar, 5000)
        '    PRM(3).Value = FULL_NAME
        '    PRM(4) = New SqlParameter("@FIRST_NAME", SqlDbType.NVarChar, 5000)
        '    PRM(4).Value = FIRST_NAME
        '    PRM(5) = New SqlParameter("@SECOND_NAME", SqlDbType.NVarChar, 5000)
        '    PRM(5).Value = SECOND_NAME
        '    PRM(6) = New SqlParameter("@THIRD_NAME", SqlDbType.NVarChar, 5000)
        '    PRM(6).Value = THIRD_NAME
        '    PRM(7) = New SqlParameter("@FORTH_NAME", SqlDbType.NVarChar, 5000)
        '    PRM(7).Value = FORTH_NAME
        '    PRM(8) = New SqlParameter("@FAMILY_NAME", SqlDbType.NVarChar, 5000)
        '    PRM(8).Value = FAMILY_NAME
        '    PRM(9) = New SqlParameter("@BIRTH_DATE", SqlDbType.Date)
        '    PRM(9).Value = BIRTH_DATE
        '    PRM(10) = New SqlParameter("@CARRER", SqlDbType.NVarChar, 5000)
        '    PRM(10).Value = CARRER
        '    PRM(11) = New SqlParameter("@ADDRESS", SqlDbType.NVarChar, 5000)
        '    PRM(11).Value = ADDRESS
        '    CON.EXECUTE_STORE("ADD_TO_ELECTIONS", PRM)
        'CON.EXECUTE_TXT("INSERT INTO [dbo].[REMAIN]
        '      ([CODE]
        '      ,[TOTAL_CLAIM]
        '      ,[PAY])
        'VALUES
        '     (" & CODE & "," & TOTAL_PAY & "," & PAY_ & ")")
        CON.EXECUTE_TXT("UPDATE MAIN SET REASON_DUE='" & REASON_DUE & "' WHERE CODE=" & CODE & "")
        '   CON.EXECUTE_TXT("INSERT INTO [dbo].[CASE_CIVIL_ID]
        '      ([CODE]
        '      ,[CIVIL_ID]
        '     )
        'VALUES
        '      (" & CODE & "," & TOTAL & ")")
        '       CON.EXECUTE_TXT("UPDATE [dbo].[CASE_CIVIL_ID]
        '  SET [CASE_CIVIL_ID] = " & TOTAL & "
        '     ,[DKHLEA_CASE] = " & TOTAL & "
        '     ,[KHESM_CASE] = " & TOTAL & "
        '     ,[CASE_TOWASEL] = " & TOTAL & "
        '     ,[CASE_MOTWASEL] = " & TOTAL & "

        'WHERE CODE=" & CODE & "")
        'CON.EXECUTE_TXT("DELETE FROM PAY WHERE CODE=" & CODE & "")
        'CON.EXECUTE_TXT("UPDATE MAIN SET BATCH_NO='" & CONCREATE & "' WHERE CODE=" & CODE & "")
        'CON.EXECUTE_TXT("UPDATE MAIN SET AUTO_NUM='" & CONCREATE & "' WHERE CODE=" & CODE & "")
        'CON.EXECUTE_TXT("UPDATE EMPLOYEE SET IS_VOKE='" & CONCREATE & "' WHERE CODE=" & CODE & "")
        'Public Sub UPDATE_CONCREATE_NUM(CODE As Double, NUM As Double)
        '    Dim CON As New CLS_CON_TELE
        'CON.EXECUTE_TXT("UPDATE MAIN SET AUTO_NUM='" & NUM & "' WHERE CODE=" & CODE & "")
    End Sub
    Public Function SELECT_(CODE As Double, CONC As String)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("UPDATE ELECTIONS SET TYPE='" & CONC & "' WHERE ID=" & CODE & "")
        Return DT
    End Function
    Public Sub ADD_STATMENT(CODE As Integer, DATE_EVENT As Date, COMON As String, DATE_REV As Date, EMPLOY As String, STAT As String,
                            WAY As String, NUM As String, NUMBER_US As String)
        Dim CON As New CLS_CON_TELE
        Dim PRM(8) As SqlParameter
        PRM(0) = New SqlParameter("@CODE", SqlDbType.Int)
        PRM(0).Value = CODE
        PRM(1) = New SqlParameter("@DATE1", SqlDbType.Date)
        PRM(1).Value = DATE_EVENT
        PRM(2) = New SqlParameter("@COM", SqlDbType.NVarChar, 500000000)
        PRM(2).Value = COMON
        PRM(3) = New SqlParameter("@DATE2", SqlDbType.Date)
        PRM(3).Value = DATE_REV
        PRM(4) = New SqlParameter("@EMP", SqlDbType.NVarChar, 500000000)
        PRM(4).Value = EMPLOY
        PRM(5) = New SqlParameter("@STAT", SqlDbType.NVarChar, 500000000)
        PRM(5).Value = STAT
        PRM(6) = New SqlParameter("@WAY", SqlDbType.NVarChar, 500000000)
        PRM(6).Value = WAY
        PRM(7) = New SqlParameter("@NUM", SqlDbType.NVarChar, 500000000)
        PRM(7).Value = NUM
        PRM(8) = New SqlParameter("@NUMBER_US", SqlDbType.NVarChar, 500000000)
        PRM(8).Value = NUMBER_US
        CON.EXECUTE_STORE("CC", PRM)
    End Sub
    Public Sub DELETE_FROM_CASE_CIVIL(CODE As Double, NAME As String)
        Dim CON As New CLS_CON_TELE
        Dim X As String = "الميزانية العمومية"
        'CON.EXECUTE_TXT("UPDATE MAIN SET WORK_NOTE = '" & MOHAD & "' WHERE CIVIL_ID=" & CIVI_ID & "")
        CON.EXECUTE_TXT("INSERT INTO [dbo].[ACC_TREE]
           ([CODE],[PARENT_CODE],[NAME],[END_ACCOUNT],[LEVEL_],[EMP])
     VALUES
           (" & CODE & ", 121,'" & NAME & "','" & X & "', '5' , 190)")
    End Sub
    Public Sub UPDATE_FROM_CASE_CIVIL(CODE As Double, CASE_CIVIL_ID As Double, DKHLEA_CASE As Double, KHESM_CASE As Double, CASE_TOWASEL As Double,
                                      CASE_MOTWASEL As Double)
        Dim CON As New DataAccessLayer
        Dim PRM(5) As SqlParameter
        PRM(0) = New SqlParameter("@CODE", SqlDbType.Float)
        PRM(0).Value = CODE
        PRM(1) = New SqlParameter("@CASE_CIVIL_ID", SqlDbType.Float)
        PRM(1).Value = CASE_CIVIL_ID
        PRM(2) = New SqlParameter("@DKHLEA_CASE", SqlDbType.Int)
        PRM(2).Value = DKHLEA_CASE
        PRM(3) = New SqlParameter("@KHESM_CASE", SqlDbType.Int)
        PRM(3).Value = KHESM_CASE
        PRM(4) = New SqlParameter("@CASE_TOWASEL", SqlDbType.Int)
        PRM(4).Value = CASE_TOWASEL
        PRM(5) = New SqlParameter("@CASE_MOTWASEL", SqlDbType.Int)
        PRM(5).Value = CASE_MOTWASEL
        CON.EXECUTECOMMAND("UPDATE [dbo].[CASE_CIVIL_ID]
                           SET [CASE_CIVIL_ID] = @CASE_CIVIL_ID
                              ,[DKHLEA_CASE] = @DKHLEA_CASE
                              ,[KHESM_CASE] = @KHESM_CASE
                              ,[CASE_TOWASEL] =@CASE_TOWASEL
                              ,[CASE_MOTWASEL] = @CASE_MOTWASEL
                              WHERE CODE = @CODE", PRM)
    End Sub
    Public Sub UPDATE_FROM_CASE_CIVILv(CASE_CIVIL_ID As Double, DKHLEA_CASE As Double,
                                       KHESM_CASE As Double, CASE_MOTWASEL As Double,
                                       CIVIL_ID As Double)
        Dim CON As New DataAccessLayer
        Dim PRM(4) As SqlParameter
        PRM(0) = New SqlParameter("@CASE_CIVIL_ID", SqlDbType.Float)
        PRM(0).Value = CASE_CIVIL_ID
        PRM(1) = New SqlParameter("@DKHLEA_CASE", SqlDbType.Float)
        PRM(1).Value = DKHLEA_CASE
        PRM(2) = New SqlParameter("@KHESM_CASE", SqlDbType.Float)
        PRM(2).Value = KHESM_CASE
        PRM(3) = New SqlParameter("@CASE_MOTWASEL", SqlDbType.Float)
        PRM(3).Value = CASE_MOTWASEL
        PRM(4) = New SqlParameter("@CIVIL_ID", SqlDbType.Float)
        PRM(4).Value = CIVIL_ID
        CON.EXECUTECOMMAND("UPDATE [dbo].[CASE_CIVIL_ID]
                            SET  [CASE_CIVIL_ID] = @CASE_CIVIL_ID
                                ,[DKHLEA_CASE] = @DKHLEA_CASE
                                ,[KHESM_CASE] = @KHESM_CASE
                                ,[CASE_MOTWASEL] = @CASE_MOTWASEL
                            WHERE CIVIL_ID = @CIVIL_ID", PRM)
    End Sub
    Public Sub UPDATE_FROM_CASE_C(CODE As Double, MOTWASEL As Double)
        Dim CON As New DataAccessLayer
        Dim PRM(1) As SqlParameter
        PRM(0) = New SqlParameter("@CODE", SqlDbType.Float)
        PRM(0).Value = CODE
        PRM(1) = New SqlParameter("@MOTWASEL", SqlDbType.Float)
        PRM(1).Value = MOTWASEL
        CON.EXECUTECOMMAND("UPDATE [dbo].[CASE_CIVIL_ID]
                            SET  [CASE_TOWASEL] = @MOTWASEL
                            WHERE CODE = @CODE", PRM)
    End Sub
    Public Sub UPDATE_MAIN_BATCH(CODE As Double)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("UPDATE NUMBER SET NOTE = '0' WHERE ID = " & CODE & "")
    End Sub
    Public Sub UPDATE_TRANS_PAY(ID As Double, TRANS_DATE As Date)
        Dim CON As New DataAccessLayer
        Dim PRM(1) As SqlParameter
        PRM(0) = New SqlParameter("@ID", SqlDbType.Float)
        PRM(0).Value = ID
        PRM(1) = New SqlParameter("@DATE", SqlDbType.Date)
        PRM(1).Value = TRANS_DATE
        'PRM(2) = New SqlParameter("@DATE2", SqlDbType.Date)
        'PRM(2).Value = BACK_DATE
        CON.EXECUTECOMMAND("UPDATE [dbo].[PAY] SET [TRANS_DATE] = @DATE  WHERE ID=@ID", PRM)
    End Sub
    Public Sub UPDATE_CASE_CIVIL_ID(CODE As Double, AMOUNT As Double, DTP As Date)
        Dim CON As New DataAccessLayer
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@DTP", SqlDbType.Date)
        PRM(0).Value = DTP
        CON.EXECUTECOMMAND("UPDATE REMAIN SET LAST_PAY = " & AMOUNT & " , DATE_LAST = @DTP WHERE CODE = " & CODE & "", PRM)
    End Sub
    Public Sub PHONE(ID As Double)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("UPDATE NUMBER SET OWNER = 'العميل' WHERE ID = " & ID & "")
    End Sub
    Public Function SELECT_NOTE(ID As Double)
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT NOTE FROM STATEMENT_2 WHERE ID=" & ID & "")
        Return DT
    End Function
    Public Sub ADD_NOTE(CODE As Double, DATE_EVENT As Date, EVENT_ As String, REVIEW_EVENT As Date)
        Dim CON As New DataAccessLayer
        Dim PRM(3) As SqlParameter
        PRM(0) = New SqlParameter("@DATE_EVENT", SqlDbType.Date)
        PRM(0).Value = DATE_EVENT
        PRM(1) = New SqlParameter("@EVENT_", SqlDbType.NVarChar, 5000)
        PRM(1).Value = EVENT_
        PRM(2) = New SqlParameter("@REVIEW_EVENT", SqlDbType.Date)
        PRM(2).Value = REVIEW_EVENT
        PRM(3) = New SqlParameter("@CODE", SqlDbType.Float)
        PRM(3).Value = CODE
        CON.EXECUTECOMMAND("UPDATE [dbo].[REMAIN]
                           SET [DATE_EVENT] = @DATE_EVENT
                              ,[EVENT] = @EVENT_
                              ,[REVIEW_EVENT] = @REVIEW_EVENT
                           WHERE CODE = @CODE", PRM)
    End Sub
    Public Sub RESON(CODE As Double, PROCE As String, DATE_ As Date, DATE_PRO As Date, NOTE As String, EMP As Double, AUTO_NUM As Double)
        Dim CON As New DataAccessLayer
        Dim PRM(1) As SqlParameter
        PRM(0) = New SqlParameter("@DATE", SqlDbType.Date)
        PRM(0).Value = DATE_
        PRM(1) = New SqlParameter("@DATE_PRO", SqlDbType.Date)
        PRM(1).Value = DATE_PRO
        CON.EXECUTECOMMAND("INSERT INTO [dbo].[IMP_NEXT_PROCECER]
           ([CODE],[DATE_],[DATE_PRO],[PROCE],[NOTE],[EMP],[IS_VOKE],[AUTO_NUM])
                VALUES
           (" & CODE & ",@DATE,@DATE_PRO,'" & PROCE & "','" & NOTE & "'," & EMP & ",1," & AUTO_NUM & ")", PRM)
    End Sub
    Public Sub ADD_MOKEL(CODE As Double, NAME_MOKEL As String, SEFA As String, CIVIL_ID As Double,
                         NATIONALITY As String)
        Dim CON As New DataAccessLayer
        Dim PRM(9) As SqlParameter
        PRM(0) = New SqlParameter("@CODE", SqlDbType.Float)
        PRM(0).Value = CODE
        PRM(1) = New SqlParameter("@NAME_MOKEL", SqlDbType.NVarChar, 500000)
        PRM(1).Value = NAME_MOKEL
        PRM(2) = New SqlParameter("@DATE_TAKOD", SqlDbType.Date)
        PRM(2).Value = Today.ToShortDateString()
        PRM(3) = New SqlParameter("@DATE_FINAL", SqlDbType.Date)
        PRM(3).Value = Today.ToShortDateString()
        PRM(4) = New SqlParameter("@TYPE_MOKEL", SqlDbType.NVarChar)
        PRM(4).Value = "شركات"
        PRM(5) = New SqlParameter("@CONTRACT_CASE", SqlDbType.NVarChar)
        PRM(5).Value = "يوجد عقد"
        PRM(6) = New SqlParameter("@SEFA", SqlDbType.NVarChar)
        PRM(6).Value = SEFA
        PRM(7) = New SqlParameter("@CIVIL_ID", SqlDbType.Float)
        PRM(7).Value = CIVIL_ID
        PRM(8) = New SqlParameter("@NATIONALITY", SqlDbType.NVarChar)
        PRM(8).Value = NATIONALITY
        PRM(9) = New SqlParameter("@WEKALLA_CASE", SqlDbType.NVarChar)
        PRM(9).Value = "يوجد وكالة"
        CON.EXECUTECOMMAND("INSERT INTO [dbo].[IMP_NEW_MOKEL]
           ([CODE],[NAME_MOKEL],[DATE_TAKOD],[DATE_FINAL],[TYPE_MOKEL],[TOTAL_ATTAB],[RATIO],[SEFA],[CIVIL_ID]
           ,[NATIONALITY],[CONTRACT_CASE],[WEKALLA_CASE])
            VALUES
           (@CODE,@NAME_MOKEL,@DATE_TAKOD,@DATE_FINAL,@TYPE_MOKEL,0,1,@SEFA,@CIVIL_ID,@NATIONALITY,
            @CONTRACT_CASE,@WEKALLA_CASE)", PRM)
    End Sub
    Public Sub ADD_SUB_NUM(CODE As Double, SUB_NUM As Double, C_NAME As String)
        Dim CON As New DataAccessLayer
        Dim PRM(2) As SqlParameter
        PRM(0) = New SqlParameter("@CODE", SqlDbType.Float)
        PRM(0).Value = CODE
        PRM(1) = New SqlParameter("@SUB_NUM", SqlDbType.Float)
        PRM(1).Value = SUB_NUM
        PRM(2) = New SqlParameter("@C_NAME", SqlDbType.NVarChar)
        PRM(2).Value = C_NAME
        CON.EXECUTECOMMAND("INSERT INTO [dbo].[IMP_SUB_MOKEL]
           ([CODE],[SUB_NUM],[C_NAME])
            VALUES
           (@CODE,@SUB_NUM,@C_NAME)", PRM)
    End Sub
    Public Sub DELETE_PHONE(CODE As Double, N1 As String)
        Dim CON As New CLS_CON_TELE
        'CON.EXECUTE_TXT("DELETE FROM NUMBER WHERE ID = " & ID & "")
        CON.EXECUTE_TXT("UPDATE MAIN SET CONTRACT_NUM = '" & N1 & "'  WHERE CODE  = " & CODE & "")
    End Sub
    Public Sub UPDATE_PROCEGER(ID As Double, NOTE As String)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("UPDATE IMP_NEXT_PROCECER SET NOTE = '" & NOTE & "' WHERE ID = " & ID & "")
    End Sub
    Public Sub ADD_GLASAT(CODE As Double, GLSA As String, DATE_GLSA As Date, CASE_GLSA As String, TYPE_GLSA As String)
        Dim CON As New DataAccessLayer
        Dim PRM(0) As SqlParameter
        PRM(0) = New SqlParameter("@DTP", SqlDbType.Date)
        PRM(0).Value = DATE_GLSA
        CON.EXECUTECOMMAND("INSERT INTO [dbo].[IMP_GLASAT]
           ([CODE],[GLSA],[DATE_GLSA],[CASE_GLSA],[TYPE_GLSA])
             VALUES
           (" & CODE & ",'" & GLSA & "',@DTP ,'" & CASE_GLSA & "','" & TYPE_GLSA & "')", PRM)
    End Sub
    Public Sub ADD_ELECTIONS(FULL_NAME As String, FIRST_NAME As String, SECOND_NAME As String, THIRD_NAME As String,
                             FORTH_NAME As String, FAMILY_NAME As String, CARRER As String, ADDRESS As String, CIVIL_ID As Double, NOTE As String, INTERNAL As String)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("INSERT INTO [dbo].[ELECTIONS]
           ([FULL_NAME],[FIRST_NAME],[SECOND_NAME],[THIRD_NAME],[FORTH_NAME],[FAMILY_NAME],[CARRER],[ADDRESS],[CIVIL_ID],[NOTE],[INTERNAL])
     VALUES
           ('" & FULL_NAME & "','" & FIRST_NAME & "','" & SECOND_NAME & "','" & THIRD_NAME & "','" & FORTH_NAME & "','" & FAMILY_NAME & "','" & CARRER & "','" & ADDRESS & "'," & CIVIL_ID & ",'" & NOTE & "'," & INTERNAL & ")")
    End Sub
    Public Sub UPDATE_ELECTION(ID As Double, NOTE As String)
        Dim CON As New CLS_CON_TELE
        CON.SELECT_TXT("UPDATE ELECTIONS SET NOTE = '" & NOTE & "' WHERE ID = " & ID & "")
    End Sub
    Public Sub ADD_CLIENT(COMPANY As Double, ID As Double)
        Dim CON As New CLS_CON_TELE
        CON.SELECT_TXT("UPDATE HONESTY SET COMPANY = " & COMPANY & " WHERE ID = " & ID & "")
    End Sub
    Public Sub ADD_MAIN(CODE As Double)
        Dim CON As New CLS_CON_TELE
        CON.SELECT_TXT("UPDATE MAIN SET CODE_CLINT = 15 WHERE CODE = " & CODE & "")
    End Sub
    Public Sub add_clint(ID As Double, NEW_ACC As Double)
        Dim CON As New CLS_CON_TELE
        Dim X As String = "الميزانية العمومية"
        CON.SELECT_TXT("UPDATE ACC_ACTIONS SET CODE_T = " & NEW_ACC & " WHERE ID = " & ID & "")
    End Sub
    Public Sub ADD_PROCESS(CODE As Double, DATE_ As Date, DATE_PRO As Date, OLD_PROCES As Integer, DATE_REVIEW As Date, NEXT_PROCE As Integer,
                       NOTE As String, EMP As Integer, IS_VOKE As String, AUTO_NUM As Integer)
        Dim CON As New DataAccessLayer
        Dim PRM(2) As SqlParameter
        PRM(0) = New SqlParameter("@DTP1", SqlDbType.Date)
        PRM(0).Value = DATE_
        PRM(1) = New SqlParameter("@DTP2", SqlDbType.Date)
        PRM(1).Value = DATE_PRO
        PRM(2) = New SqlParameter("@DTP3", SqlDbType.Date)
        PRM(2).Value = DATE_REVIEW
        CON.EXECUTECOMMAND("INSERT INTO [dbo].[IMP_NEXT_PROCECER]
           ([CODE],[DATE_],[DATE_PRO],[OLD_PROCES],[DATE_REVIEW],[NEXT_PROCE],[NOTE],[EMP],[IS_VOKE],[AUTO_NUM])
     VALUES
           (" & CODE & ", @DTP1,@DTP2 ," & OLD_PROCES & " ,@DTP3, " & NEXT_PROCE & ",  '" & NOTE & "', " & EMP & ", '" & IS_VOKE & "', 
            " & AUTO_NUM & ")", PRM)
    End Sub
    Public Sub UpdateComputerName()
        Dim Con As New DataAccessLayer
        Dim Prm(0) As SqlParameter
        Prm(0) = New SqlParameter("@DTP", SqlDbType.Date)
        Prm(0).Value = Today.Now
        Dim host_name As String = Dns.GetHostName()
        Dim ip_address As String = Dns.GetHostByName(host_name).AddressList(3).ToString()
        Con.EXECUTECOMMAND("INSERT INTO [dbo].[CNameTest]
                            ([CODE], [C_NAME], [DATE_])
                              VALUES
                            (" & My.Settings.EMPLOYEE & ", '" & ip_address & "', @DTP)", Prm)
    End Sub
    Public Sub ADD_RANDOM(_RANDOM As Integer)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("UPDATE EMPLOYEE SET RANDOM_USER = " & _RANDOM & " WHERE CODE = " & My.Settings.EMPLOYEE & "")
    End Sub
    Public Function _RANDOM()
        Dim CON As New CLS_CON_TELE
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT RANDOM_USER, ACTIVEE FROM EMPLOYEE WHERE CODE = " & My.Settings.EMPLOYEE & "")
        Return DT
    End Function
    Public Sub MACADDRESS(MAC As String)
        Dim CON As New CLS_CON_TELE
        CON.EXECUTE_TXT("UPDATE EMPLOYEE SET MACADDRESS = '" & MAC & "' WHERE CODE = " & My.Settings.EMPLOYEE & "")
    End Sub
End Class