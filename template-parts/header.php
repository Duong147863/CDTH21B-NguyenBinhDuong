<div class="header">
	<div class="container">
		<div class="logo">
			<a href="<?php echo esc_url( home_url('/') ); ?>">
				<img src="<?php echo get_theme_file_uri(); ?>/img/logo.png" alt="<?php bloginfo('name'); ?>">
			</a>
		</div>

		<!-- Menu Hamburger (Default) -->
		<button class="main-menu-indicator" id="open-button">
			<span class="line"></span>
		</button>

		<div class="menu-wrap" style="background-image: url('<?php echo get_theme_file_uri(); ?>/img/nav_bg.jpg')">
			<div class="menu-content">
                <?php get_template_part('template-parts/search-form'); ?>
				<nav class="menu">
					<div class="menu-list">
						<ul>
							<li class="menu-item-has-children"><a href="#">Home</a>
								<ul class="sub-menu">
									<li><a href="index.html">- Default</a></li>
									<li><a href="index-architecture.html">- Architecture</a></li>
									<li><a href="index-full-slider.html">- Slider Full Width</a></li>
								</ul>
							</li>
							<li><a href="about.html">About</a></li>
							<li class="menu-item-has-children"><a href="#">Portfolio</a>
								<ul class="sub-menu">
									<li><a href="portfolio-2column.html">-Portfolio 2 Column</a></li>
									<li><a href="portfolio-3column.html">-Portfolio 3 Column</a></li>
									<li><a href="portfolio-masonry.html">-Portfolio Masonry</a></li>
									<li><a href="portfolio-dribbble.html">-Portfolio Dribbble</a></li>
								</ul>
							</li>
							<li class="menu-item-has-children"><a href="#">Blog</a>
								<ul class="sub-menu">
									<li><a href="blog.html">Blog Default</a></li>
									<li><a href="blog-timeline.html">Blog Timeline</a></li>
									<li><a href="single-blog.html">Blog Single</a></li>
								</ul>
							</li>
							<li><a href="contact.html">Contact</a></li>
						</ul>
					</div>
				</nav>

				<div class="hidden-xs">
					<div class="menu-social-media">
                        <?php get_template_part('template-parts/social-menu'); ?>
					</div>

					<div class="menu-information">
						<ul>
							<li><span>T:</span> 003 124 115</li>
							<li><span>E:</span> info@mail.com</li>
						</ul>
					</div>
				</div>
			</div>
		</div>
		<!-- End of Menu Hamburger (Default) -->

	</div>
</div>
