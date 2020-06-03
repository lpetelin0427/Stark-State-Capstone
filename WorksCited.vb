Public Class WorksCited
    Private Sub Top10QBLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Top10QBLnkLbl.LinkClicked
        Process.Start("https://www.usatoday.com/story/sports/ncaaf/2017/08/28/six-quarterbacks-nfl-draft-class-sam-darnold-josh-rosen-lamar-jackson/561024001/")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.sports-reference.com/cfb/")
    End Sub

    Private Sub Top10RBLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Top10RBLnkLbl.LinkClicked
        Process.Start("https://www.usatoday.com/story/sports/ncaaf/2017/10/10/college-football-top-10-running-backs-bryce-love-saquon-barkley/749317001/")
    End Sub

    Private Sub Top10WRLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Top10WRLnkLbl.LinkClicked
        Process.Start("http://walterfootball.com/draft2018WR.php")
    End Sub

    Private Sub Top10DTLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Top10DTLnkLbl.LinkClicked
        Process.Start("http://walterfootball.com/draft2018DT.php")
    End Sub

    Private Sub Top10LBLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Top10LBLnkLbl.LinkClicked
        Process.Start("http://walterfootball.com/draft2018ILB.php")
    End Sub


    'top 10 QBS site
    'https://www.usatoday.com/story/sports/ncaaf/2017/08/28/six-quarterbacks-nfl-draft-class-sam-darnold-josh-rosen-lamar-jackson/561024001/
    'all data used from
    'https://www.sports-reference.com/cfb/
    'top 10 RB's 
    'https://www.usatoday.com/story/sports/ncaaf/2017/10/10/college-football-top-10-running-backs-bryce-love-saquon-barkley/749317001/
    'top 10 WR
    'http://walterfootball.com/draft2018WR.php 
    'top 10 defensive tackles
    'http://walterfootball.com/draft2018DT.php
    'top 10 defensive backs
    'http://walterfootball.com/draft2018CB.php
    'top 10 linebackers
    'http://walterfootball.com/draft2018ILB.php
End Class